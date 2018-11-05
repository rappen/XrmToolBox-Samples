using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk.Metadata;
using System.Diagnostics;

namespace D365SatSampleTool
{
    public partial class SDV : PluginControlBase
    {
        public SDV()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            gridViews.OrganizationService = detail.ServiceClient;
            gridData.OrganizationService = detail.ServiceClient;
            entitiesDropdownControl1.Service = detail.ServiceClient;
        }

        private void LoadViews(EntityMetadata entitymetadata)
        {
            if (entitymetadata == null)
            {
                gridViews.DataSource = null;
                return;
            }
            WorkAsync(new WorkAsyncInfo
            {
                Message = $"Loading views for {entitymetadata.DisplayName.UserLocalizedLabel.Label}",
                AsyncArgument = entitymetadata,
                Work = (worker, args) =>
                {
                    var meta = args.Argument as EntityMetadata;
                    var qex = new QueryExpression("savedquery");
                    qex.ColumnSet.AddColumns("name", "fetchxml");
                    qex.AddOrder("name", OrderType.Ascending);
                    qex.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, meta.ObjectTypeCode);
                    qex.Criteria.AddCondition("fetchxml", ConditionOperator.NotNull);
                    args.Result = Service.RetrieveMultiple(qex);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message, "Oh crap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (args.Result is EntityCollection views)
                    {
                        gridViews.DataSource = views;
                    }
                }
            });
        }

        private void LoadData(Entity entity)
        {
            if (entity == null)
            {
                gridData.DataSource = null;
                return;
            }
            WorkAsync(new WorkAsyncInfo
            {
                Message = $"Loading data for {entity["name"]}",
                AsyncArgument = entity,
                Work = (worker, args) =>
                {
                    var etc = args.Argument as string;
                    var fex = new FetchExpression(entity["fetchxml"].ToString());
                    args.Result = Service.RetrieveMultiple(fex);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message, "Oh crap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (args.Result is EntityCollection views)
                    {
                        gridData.DataSource = views;
                    }
                }
            });
        }

        private void OpenEntityReference(EntityReference entref)
        {
            if (!string.IsNullOrEmpty(entref.LogicalName) && !entref.Id.Equals(Guid.Empty))
            {
                var url = ConnectionDetail.WebApplicationUrl;
                if (string.IsNullOrEmpty(url))
                {
                    url = string.Concat(ConnectionDetail.ServerName, "/", ConnectionDetail.Organization);
                    if (!url.ToLower().StartsWith("http"))
                    {
                        url = string.Concat("http://", url);
                    }
                }
                url = string.Concat(url,
                    url.EndsWith("/") ? "" : "/",
                    "main.aspx?etn=",
                    entref.LogicalName,
                    "&pagetype=entityrecord&id=",
                    entref.Id.ToString());
                if (!string.IsNullOrEmpty(url))
                {
                    Process.Start(url);
                }
            }
        }

        private void entitiesDropdownControl1_SelectedItemChanged(object sender, Futurez.XrmToolBox.Controls.EntitiesDropdownControl.SelectedItemChangedEventArgs e)
        {
            LoadViews(entitiesDropdownControl1.SelectedEntity);
        }

        private void gridViews_RecordEnter(object sender, Cinteros.Xrm.CRMWinForm.CRMRecordEventArgs e)
        {
            LoadData(e.Entity);
        }

        private void chkFriendly_CheckedChanged(object sender, EventArgs e)
        {
            gridData.ShowFriendlyNames = chkFriendly.Checked;
        }

        private void chkId_CheckedChanged(object sender, EventArgs e)
        {
            gridData.ShowIdColumn = chkId.Checked;
        }

        private void chkLookup_CheckedChanged(object sender, EventArgs e)
        {
            gridData.EntityReferenceClickable = chkLookup.Checked;
        }

        private void gridData_RecordDoubleClick(object sender, Cinteros.Xrm.CRMWinForm.CRMRecordEventArgs e)
        {
            if (chkDbl.Checked)
            {
                OpenEntityReference(e.Entity.ToEntityReference());
            }
        }

        private void gridData_RecordClick(object sender, Cinteros.Xrm.CRMWinForm.CRMRecordEventArgs e)
        {
            if (chkLookup.Checked && e.Value is EntityReference entref)
            {
                OpenEntityReference(entref);
            }
        }
    }
}
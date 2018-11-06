using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace D365SatSampleTool
{
    public partial class SDV : PluginControlBase, IMessageBusHost, IAboutPlugin
    {
        public SDV()
        {
            InitializeComponent();
        }

        public event EventHandler<MessageBusEventArgs> OnOutgoingMessage;

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

        public void OnIncomingMessage(MessageBusEventArgs message)
        {
            MessageBox.Show("Simple Data Viewer cannot yet handle calls from other tools.");
        }

        public void ShowAboutDialog()
        {
            MessageBox.Show("Simple Data Viewer\n\nD365 Saturday Sample project");
        }

        private void btnFXB_Click(object sender, EventArgs e)
        {
            OnOutgoingMessage(this, new MessageBusEventArgs("FetchXML Builder")
            {
                TargetArgument = gridViews.SelectedCellRecords.Entities.FirstOrDefault()["fetchxml"]
            });
        }
    }
}
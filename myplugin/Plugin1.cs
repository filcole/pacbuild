using Microsoft.Xrm.Sdk;
using System;

namespace myplugin
{
    /// <summary>
    /// Plugin development guide: https://docs.microsoft.com/powerapps/developer/common-data-service/plug-ins
    /// Best practices and guidance: https://docs.microsoft.com/powerapps/developer/common-data-service/best-practices/business-logic/
    /// </summary>
    public class Plugin1 : PluginBase
    {
        public Plugin1(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(Plugin1))
        {
            // TODO: Implement your custom configuration handling
            // https://docs.microsoft.com/powerapps/developer/common-data-service/register-plug-in#set-configuration-data
        }

        private void InternalMethod(ILocalPluginContext localPluginContext) {
            localPluginContext.Trace("Tracing within a method");
        }

        // Entry point for custom business logic execution
        protected override void ExecuteCdsPlugin(ILocalPluginContext localPluginContext)
        {
            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            localPluginContext.Trace("Plugin Started v3 OnlyTracing Started");

            var context = localPluginContext.PluginExecutionContext;

            // TODO: Implement your custom business logic
            InternalMethod(localPluginContext);

            // Check for the entity on which the plugin would be registered
            //if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            //{
            //    var entity = (Entity)context.InputParameters["Target"];

            //    // Check for entity name on which this plugin would be registered
            //    if (entity.LogicalName == "account")
            //    {

            //    }
            //}
        }
    }
}

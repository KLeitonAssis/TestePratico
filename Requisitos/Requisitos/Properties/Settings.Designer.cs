﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Requisitos.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("user id=Teste;pwd=TESTE;Application Name=DEVEDORES;data source=DESKTOP-P7N6VT1;pe" +
            "rsist security info=False;connection reset=false;Pooling=true;Connection Lifetim" +
            "e=1800;initial catalog=DEVEDORES;min pool size=1;max pool size=999;Connect Timeo" +
            "ut=1800")]
        public string strConexao {
            get {
                return ((string)(this["strConexao"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("user id=ADM;pwd=ADMUSR;Application Name=TESTE;data source=TMKTBDSQL15;persist sec" +
            "urity info=False;connection reset=false;Pooling=true;Connection Lifetime=1800;in" +
            "itial catalog=TESTE;min pool size=1;max pool size=999;Connect Timeout=1800\r\n")]
        public string strConexao15 {
            get {
                return ((string)(this["strConexao15"]));
            }
        }
    }
}

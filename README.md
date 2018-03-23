# XAMARIN-APPConfig
App que usa um arquivo App.config para guardar chaves importantes para o aplicativo, tendo exatamente a mesma funcionalidades
que um web.config ou o proprio app.config do Windows.Forms e WPF.

Mas em xamarin esse arquivo não tem suporte , logo precisamos um plugin para fazer isso o PCLAppConfig
https://www.nuget.org/packages/PCLAppConfig

Git PCLAppConfig: https://github.com/mrbrl/PCLAppConfig

Passo a passo:
1º Adicione o plugin PCLAppConfig via Nuget

2º Adicione um arquivo de configuração(App.config) com as variaveis que deseja ali guardar

<configuration> 
  <appSettings> 
    <add key="config.text" value="hello from app.settings!" /> 
  </appSettings> 
</configuration>

3º Inicialize o plugin no App.xaml.cs 

  Assembly assembly = typeof(App).GetTypeInfo().Assembly;
	ConfigurationManager.Initialise(assembly.GetManifestResourceStream("XamarinConfig.App.config"));
  
4º Busque pelas suas chaves seus respctivos valores (Access your setting)
   
   ConfigurationManager.AppSettings["config.text"];

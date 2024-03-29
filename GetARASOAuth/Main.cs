/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘GetARASOAuth.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir23 = null;
        public BindDirection bind_dir24 = null;
        public BindDirection bind_dir25 = null;
        public BindDirection bind_dir26 = null;
        public BindDirection bind_dir27 = null;
        public BindDirection bind_dir28 = null;
        public BindDirection bind_dir29 = null;
        public BindDirection bind_dir30 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.Sequence11 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence11");
            _flow.HTTPActivity4 = new HP.ST.Ext.HTTPActivity.HTTPActivity(_context,"HTTPActivity4");
            _flow.ConcatenateStringsActivity9 = new HP.ST.Ext.BasicActivities.ConcatenateStringsActivity(_context,"ConcatenateStringsActivity9");
            _flow.HTTPActivity6 = new HP.ST.Ext.HTTPActivity.HTTPActivity(_context,"HTTPActivity6");
            _flow.HTTPActivity8 = new HP.ST.Ext.HTTPActivity.HTTPActivity(_context,"HTTPActivity8");
            _flow.ConcatenateStringsActivity10 = new HP.ST.Ext.BasicActivities.ConcatenateStringsActivity(_context,"ConcatenateStringsActivity10");
            XmlDocument StartActivity1_ExecutionInputParameters_Document = new XmlDocument();
            StartActivity1_ExecutionInputParameters_Document.PreserveWhitespace = true;
            StartActivity1_ExecutionInputParameters_Document.LoadXml(
@"<Arguments><Proxy>http://127.0.0.1:3128</Proxy></Arguments>");
            _flow.StartActivity1.ExecutionInputParameters = StartActivity1_ExecutionInputParameters_Document;
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"This module contains NO testcases, the actions inside try to provide an access token for other tests/testcases for an ARAS System";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (_flow.Sequence11);
            this.Activities.Add (_flow.Loop2);
            XmlDocument EndActivity3_ExecutionOutputParameters_Document = new XmlDocument();
            EndActivity3_ExecutionOutputParameters_Document.PreserveWhitespace = true;
            EndActivity3_ExecutionOutputParameters_Document.LoadXml(
@"<Arguments><AccessToken>{Step.OutputProperties.ConcatenateStringsActivity10.Result}</AccessToken></Arguments>");
            _flow.EndActivity3.ExecutionOutputParameters = EndActivity3_ExecutionOutputParameters_Document;
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            VTDPropertyInfoBase pi45 = new VTDPropertyInfoBase("Result");
            VTDBaseGetter binding_getter23 = new VTDObjectGetter(pi45);
            VTDPropertyInfoBase pi46 = new VTDPropertyInfoBase("ExecutionOutputParameters","/*[local-name(.)='Arguments'][1]/*[local-name(.)='AccessToken'][1]");
            VTDBaseSetter binding_setter23 = new VTDXPathSetter(pi46,XmlTypeCode.String);
            binding_setter23 = new StringFormaterDecorator(binding_setter23,"{Step.OutputProperties.ConcatenateStringsActivity10.Result}");
            bind_dir23 = new BindDirection(_flow.ConcatenateStringsActivity10,binding_getter23,binding_setter23,BindTargetType.ToInProperty);
            _flow.EndActivity3.InDirections.Add(bind_dir23);
            this.Activities.Add (_flow.EndActivity3);
            _flow.Sequence11.Comment = @"";
            _flow.Sequence11.IconPath = @"";
            _flow.Sequence11.Name = @"Sequence11";
            _flow.Sequence11.Activities.Add (_flow.HTTPActivity4);
            _flow.Sequence11.Activities.Add (_flow.ConcatenateStringsActivity9);
            _flow.Sequence11.Activities.Add (_flow.HTTPActivity6);
            _flow.Sequence11.Activities.Add (_flow.HTTPActivity8);
            _flow.Sequence11.Activities.Add (_flow.ConcatenateStringsActivity10);
            _flow.HTTPActivity4.TextBody = @"";
            _flow.HTTPActivity4.TextXmlBody = @"";
            _flow.HTTPActivity4.FileBody = @"";
            _flow.HTTPActivity4.PostBody = @"";
            _flow.HTTPActivity4.Url = @"http://80.158.47.39/11SP15_Demo/Server/OAuthServerDiscovery.aspx";
            _flow.HTTPActivity4.HttpMethod = @"GET";
            _flow.HTTPActivity4.HttpVersion = @"1.1";
            _flow.HTTPActivity4.Comment = @"";
            _flow.HTTPActivity4.IconPath = @"AddIns\ServiceTest\HTTPActivity\toolbox_http.png";
            _flow.HTTPActivity4.RequestBodyType = @"Text";
            _flow.HTTPActivity4.ResponseType = @"Json";
            _flow.HTTPActivity4.Name = @"GetOAuthLocation";
            _flow.HTTPActivity4.Proxy.Server = @"{Step.OutputProperties.StartActivity1.Proxy}";
            _flow.HTTPActivity4.Proxy.Username = @"";
            _flow.HTTPActivity4.Proxy.Password = @"";
            _flow.HTTPActivity4.Authentication.Username = @"";
            _flow.HTTPActivity4.Authentication.Password = @"";
            _flow.HTTPActivity4.Authentication.PreemptiveAuthentication = false;
            _flow.HTTPActivity4.ConnectionType = @"Keep-Alive";
            _flow.HTTPActivity4.Timeout = (int)100000;
            _flow.HTTPActivity4.ClientCertificate.Password = @"";
            _flow.HTTPActivity4.ClientCertificate.FileSystem.Path = @"";
            _flow.HTTPActivity4.UseClientCertificate = false;
            _flow.HTTPActivity4.MaximumAutomaticRedirections = (int)3;
            _flow.HTTPActivity4.AllowRedirections = true;
            _flow.HTTPActivity4.ReuseCookies = true;
            _flow.HTTPActivity4.ExpectServerError = false;
            _flow.HTTPActivity4.HanaRequest = false;
            XmlDocument HTTPActivity4_XMLBody_Document = new XmlDocument();
            HTTPActivity4_XMLBody_Document.PreserveWhitespace = true;
            HTTPActivity4_XMLBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity4.XMLBody = HTTPActivity4_XMLBody_Document;
            XmlDocument HTTPActivity4_RequestMultipartInfoXml_Document = new XmlDocument();
            HTTPActivity4_RequestMultipartInfoXml_Document.PreserveWhitespace = true;
            HTTPActivity4_RequestMultipartInfoXml_Document.LoadXml(
@"<RequestMultipartInfo><Type>Related</Type></RequestMultipartInfo>");
            _flow.HTTPActivity4.RequestMultipartInfoXml = HTTPActivity4_RequestMultipartInfoXml_Document;
            _flow.HTTPActivity4.Multipart=false;
            VTDPropertyInfoBase pi47 = new VTDPropertyInfoBase("ExecutionInputParameters","/*[local-name(.)='Arguments'][1]/*[local-name(.)='Proxy'][1]");
            VTDBaseGetter binding_getter24 = new VTDXPathGetter(pi47,XmlTypeCode.String);
            VTDPropertyInfoBase pi48 = new VTDPropertyInfoBase("Proxy.Server");
            VTDBaseSetter binding_setter24 = new VTDObjectSetter(pi48);
            binding_setter24 = new StringFormaterDecorator(binding_setter24,"{Step.OutputProperties.StartActivity1.Proxy}");
            bind_dir24 = new BindDirection(_flow.StartActivity1,binding_getter24,binding_setter24,BindTargetType.ToInProperty);
            _flow.HTTPActivity4.InDirections.Add(bind_dir24);
            XmlDocument HTTPActivity4_ExpectedResponseXmlBody_Document = new XmlDocument();
            HTTPActivity4_ExpectedResponseXmlBody_Document.PreserveWhitespace = true;
            HTTPActivity4_ExpectedResponseXmlBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity4.ExpectedResponseXmlBody = HTTPActivity4_ExpectedResponseXmlBody_Document;
            XmlDocument HTTPActivity4_ExpectedResponseJsonBody_Document = new XmlDocument();
            HTTPActivity4_ExpectedResponseJsonBody_Document.PreserveWhitespace = true;
            HTTPActivity4_ExpectedResponseJsonBody_Document.LoadXml(
@"<Object jsonType=""Object"" isAnonymous=""true""><locations jsonType=""Array""><Object jsonType=""Object"" isAnonymous=""true""><uri jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/</uri></Object></locations></Object>");
            _flow.HTTPActivity4.ExpectedResponseJsonBody = HTTPActivity4_ExpectedResponseJsonBody_Document;
            XmlDocument HTTPActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            HTTPActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            HTTPActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Arguments><ResponseHttpVersion /><StatusCode /><StatusDescription /><ResponseBody /><ResponseBodyAsBase64 /></Arguments>");
            _flow.HTTPActivity4.ExpectedOutputProperties = HTTPActivity4_ExpectedOutputProperties_Document;
            _flow.ConcatenateStringsActivity9.Prefix = @"{Step.ResponseJsonBody.HTTPActivity4.locations.Object.uri}";
            _flow.ConcatenateStringsActivity9.Suffix = @".well-known/openid-configuration";
            _flow.ConcatenateStringsActivity9.Comment = @"";
            _flow.ConcatenateStringsActivity9.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_concat.png";
            _flow.ConcatenateStringsActivity9.Name = @"OAuthConfigURL";
            VTDPropertyInfoBase pi49 = new VTDPropertyInfoBase("XMLResponse","/*[local-name(.)='Object'][1]/*[local-name(.)='locations'][1]/*[local-name(.)='Object'][1]/*[local-name(.)='uri'][1]");
            VTDBaseGetter binding_getter25 = new VTDJsonGetter(pi49);
            VTDPropertyInfoBase pi50 = new VTDPropertyInfoBase("Prefix");
            VTDBaseSetter binding_setter25 = new VTDObjectSetter(pi50);
            binding_setter25 = new StringFormaterDecorator(binding_setter25,"{Step.ResponseJsonBody.HTTPActivity4.locations.Object.uri}");
            bind_dir25 = new BindDirection(_flow.HTTPActivity4,binding_getter25,binding_setter25,BindTargetType.ToInProperty);
            _flow.ConcatenateStringsActivity9.InDirections.Add(bind_dir25);
            _flow.HTTPActivity6.TextBody = @"";
            _flow.HTTPActivity6.TextXmlBody = @"";
            _flow.HTTPActivity6.FileBody = @"";
            _flow.HTTPActivity6.PostBody = @"";
            _flow.HTTPActivity6.Url = @"{Step.OutputProperties.ConcatenateStringsActivity9.Result}";
            _flow.HTTPActivity6.HttpMethod = @"GET";
            _flow.HTTPActivity6.HttpVersion = @"1.1";
            _flow.HTTPActivity6.RequestHeaders = new Pair<string, string>[1];
            _flow.HTTPActivity6.RequestHeaders[0] = new Pair<string, string>();
            _flow.HTTPActivity6.RequestHeaders[0].Key = @"Accept";
            _flow.HTTPActivity6.RequestHeaders[0].Value = @"application/json";
            _flow.HTTPActivity6.Comment = @"";
            _flow.HTTPActivity6.IconPath = @"AddIns\ServiceTest\HTTPActivity\toolbox_http.png";
            _flow.HTTPActivity6.RequestBodyType = @"Text";
            _flow.HTTPActivity6.ResponseType = @"Json";
            _flow.HTTPActivity6.Name = @"GetOAuthConfig";
            _flow.HTTPActivity6.Proxy.Server = @"{Step.OutputProperties.StartActivity1.Proxy}";
            _flow.HTTPActivity6.Proxy.Username = @"";
            _flow.HTTPActivity6.Proxy.Password = @"";
            _flow.HTTPActivity6.Authentication.Username = @"";
            _flow.HTTPActivity6.Authentication.Password = @"";
            _flow.HTTPActivity6.Authentication.PreemptiveAuthentication = false;
            _flow.HTTPActivity6.ConnectionType = @"Keep-Alive";
            _flow.HTTPActivity6.Timeout = (int)100000;
            _flow.HTTPActivity6.ClientCertificate.Password = @"";
            _flow.HTTPActivity6.ClientCertificate.FileSystem.Path = @"";
            _flow.HTTPActivity6.UseClientCertificate = false;
            _flow.HTTPActivity6.MaximumAutomaticRedirections = (int)3;
            _flow.HTTPActivity6.AllowRedirections = true;
            _flow.HTTPActivity6.ReuseCookies = true;
            _flow.HTTPActivity6.ExpectServerError = false;
            _flow.HTTPActivity6.HanaRequest = false;
            XmlDocument HTTPActivity6_XMLBody_Document = new XmlDocument();
            HTTPActivity6_XMLBody_Document.PreserveWhitespace = true;
            HTTPActivity6_XMLBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity6.XMLBody = HTTPActivity6_XMLBody_Document;
            XmlDocument HTTPActivity6_RequestMultipartInfoXml_Document = new XmlDocument();
            HTTPActivity6_RequestMultipartInfoXml_Document.PreserveWhitespace = true;
            HTTPActivity6_RequestMultipartInfoXml_Document.LoadXml(
@"<RequestMultipartInfo><Type>Related</Type></RequestMultipartInfo>");
            _flow.HTTPActivity6.RequestMultipartInfoXml = HTTPActivity6_RequestMultipartInfoXml_Document;
            _flow.HTTPActivity6.Multipart=false;
            VTDPropertyInfoBase pi51 = new VTDPropertyInfoBase("Result");
            VTDBaseGetter binding_getter26 = new VTDObjectGetter(pi51);
            VTDPropertyInfoBase pi52 = new VTDPropertyInfoBase("Url");
            VTDBaseSetter binding_setter26 = new VTDObjectSetter(pi52);
            binding_setter26 = new StringFormaterDecorator(binding_setter26,"{Step.OutputProperties.ConcatenateStringsActivity9.Result}");
            bind_dir26 = new BindDirection(_flow.ConcatenateStringsActivity9,binding_getter26,binding_setter26,BindTargetType.ToInProperty);
            _flow.HTTPActivity6.InDirections.Add(bind_dir26);
            VTDPropertyInfoBase pi53 = new VTDPropertyInfoBase("ExecutionInputParameters","/*[local-name(.)='Arguments'][1]/*[local-name(.)='Proxy'][1]");
            VTDBaseGetter binding_getter27 = new VTDXPathGetter(pi53,XmlTypeCode.String);
            VTDPropertyInfoBase pi54 = new VTDPropertyInfoBase("Proxy.Server");
            VTDBaseSetter binding_setter27 = new VTDObjectSetter(pi54);
            binding_setter27 = new StringFormaterDecorator(binding_setter27,"{Step.OutputProperties.StartActivity1.Proxy}");
            bind_dir27 = new BindDirection(_flow.StartActivity1,binding_getter27,binding_setter27,BindTargetType.ToInProperty);
            _flow.HTTPActivity6.InDirections.Add(bind_dir27);
            XmlDocument HTTPActivity6_ExpectedResponseXmlBody_Document = new XmlDocument();
            HTTPActivity6_ExpectedResponseXmlBody_Document.PreserveWhitespace = true;
            HTTPActivity6_ExpectedResponseXmlBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity6.ExpectedResponseXmlBody = HTTPActivity6_ExpectedResponseXmlBody_Document;
            XmlDocument HTTPActivity6_ExpectedResponseJsonBody_Document = new XmlDocument();
            HTTPActivity6_ExpectedResponseJsonBody_Document.PreserveWhitespace = true;
            HTTPActivity6_ExpectedResponseJsonBody_Document.LoadXml(
@"<Object jsonType=""Object"" isAnonymous=""true""><issuer jsonType=""String"">OAuthServer</issuer><jwks_uri jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/.well-known/jwks</jwks_uri><authorization_endpoint jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/connect/authorize</authorization_endpoint><token_endpoint jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/connect/token</token_endpoint><userinfo_endpoint jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/connect/userinfo</userinfo_endpoint><end_session_endpoint jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/connect/endsession</end_session_endpoint><check_session_iframe jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/connect/checksession</check_session_iframe><revocation_endpoint jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/connect/revocation</revocation_endpoint><introspection_endpoint jsonType=""String"">http://80.158.47.39/11SP15_Demo/oauthserver/connect/introspect</introspection_endpoint><frontchannel_logout_supported jsonType=""Boolean"">true</frontchannel_logout_supported><frontchannel_logout_session_supported jsonType=""Boolean"">true</frontchannel_logout_session_supported><scopes_supported jsonType=""Array""><Value jsonType=""String"" isAnonymous=""true"">Innovator</Value><Value jsonType=""String"" isAnonymous=""true"">offline_access</Value></scopes_supported><claims_supported jsonType=""Array"" /><response_types_supported jsonType=""Array""><Value jsonType=""String"" isAnonymous=""true"">code</Value><Value jsonType=""String"" isAnonymous=""true"">token</Value><Value jsonType=""String"" isAnonymous=""true"">id_token</Value><Value jsonType=""String"" isAnonymous=""true"">id_token token</Value><Value jsonType=""String"" isAnonymous=""true"">code id_token</Value><Value jsonType=""String"" isAnonymous=""true"">code token</Value><Value jsonType=""String"" isAnonymous=""true"">code id_token token</Value></response_types_supported><response_modes_supported jsonType=""Array""><Value jsonType=""String"" isAnonymous=""true"">form_post</Value><Value jsonType=""String"" isAnonymous=""true"">query</Value><Value jsonType=""String"" isAnonymous=""true"">fragment</Value></response_modes_supported><grant_types_supported jsonType=""Array""><Value jsonType=""String"" isAnonymous=""true"">authorization_code</Value><Value jsonType=""String"" isAnonymous=""true"">client_credentials</Value><Value jsonType=""String"" isAnonymous=""true"">password</Value><Value jsonType=""String"" isAnonymous=""true"">refresh_token</Value><Value jsonType=""String"" isAnonymous=""true"">implicit</Value><Value jsonType=""String"" isAnonymous=""true"">impersonate</Value></grant_types_supported><subject_types_supported jsonType=""Array""><Value jsonType=""String"" isAnonymous=""true"">public</Value></subject_types_supported><id_token_signing_alg_values_supported jsonType=""Array""><Value jsonType=""String"" isAnonymous=""true"">RS256</Value></id_token_signing_alg_values_supported><code_challenge_methods_supported jsonType=""Array""><Value jsonType=""String"" isAnonymous=""true"">plain</Value><Value jsonType=""String"" isAnonymous=""true"">S256</Value></code_challenge_methods_supported><token_endpoint_auth_methods_supported jsonType=""Array""><Value jsonType=""String"" isAnonymous=""true"">client_secret_post</Value><Value jsonType=""String"" isAnonymous=""true"">client_secret_basic</Value></token_endpoint_auth_methods_supported><protocol_version jsonType=""String"">1.0</protocol_version><protocol_info jsonType=""Object""><protocol_type jsonType=""String"">Standard</protocol_type><authorization_header jsonType=""String"">Authorization</authorization_header><www_authenticate_header jsonType=""String"">WWW-Authenticate</www_authenticate_header><unauthorized_status_code jsonType=""Integer"">401</unauthorized_status_code></protocol_info></Object>");
            _flow.HTTPActivity6.ExpectedResponseJsonBody = HTTPActivity6_ExpectedResponseJsonBody_Document;
            XmlDocument HTTPActivity6_ExpectedOutputProperties_Document = new XmlDocument();
            HTTPActivity6_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            HTTPActivity6_ExpectedOutputProperties_Document.LoadXml(
@"<Arguments><ResponseHttpVersion /><StatusCode /><StatusDescription /><ResponseBody /><ResponseBodyAsBase64 /></Arguments>");
            _flow.HTTPActivity6.ExpectedOutputProperties = HTTPActivity6_ExpectedOutputProperties_Document;
            _flow.HTTPActivity8.TextBody = @"";
            _flow.HTTPActivity8.TextXmlBody = @"";
            _flow.HTTPActivity8.FileBody = @"";
            _flow.HTTPActivity8.PostBody = @"grant_type=password&scope=Innovator&client_id=IOMApp&username=admin&password=607920B64FE136F9AB2389E371852AF2&database=11SP15_Demo";
            _flow.HTTPActivity8.Url = @"{Step.ResponseJsonBody.HTTPActivity6.token_endpoint}";
            _flow.HTTPActivity8.HttpMethod = @"POST";
            _flow.HTTPActivity8.HttpVersion = @"1.1";
            _flow.HTTPActivity8.Comment = @"";
            _flow.HTTPActivity8.IconPath = @"AddIns\ServiceTest\HTTPActivity\toolbox_http.png";
            _flow.HTTPActivity8.RequestBodyType = @"PostForm";
            _flow.HTTPActivity8.ResponseType = @"Json";
            _flow.HTTPActivity8.Name = @"GetAccessToken";
            _flow.HTTPActivity8.Proxy.Server = @"{Step.OutputProperties.StartActivity1.Proxy}";
            _flow.HTTPActivity8.Proxy.Username = @"";
            _flow.HTTPActivity8.Proxy.Password = @"";
            _flow.HTTPActivity8.Authentication.Username = @"";
            _flow.HTTPActivity8.Authentication.Password = @"";
            _flow.HTTPActivity8.Authentication.PreemptiveAuthentication = false;
            _flow.HTTPActivity8.ConnectionType = @"Keep-Alive";
            _flow.HTTPActivity8.Timeout = (int)100000;
            _flow.HTTPActivity8.ClientCertificate.Password = @"";
            _flow.HTTPActivity8.ClientCertificate.FileSystem.Path = @"";
            _flow.HTTPActivity8.UseClientCertificate = false;
            _flow.HTTPActivity8.MaximumAutomaticRedirections = (int)3;
            _flow.HTTPActivity8.AllowRedirections = true;
            _flow.HTTPActivity8.ReuseCookies = true;
            _flow.HTTPActivity8.ExpectServerError = false;
            _flow.HTTPActivity8.HanaRequest = false;
            XmlDocument HTTPActivity8_XMLBody_Document = new XmlDocument();
            HTTPActivity8_XMLBody_Document.PreserveWhitespace = true;
            HTTPActivity8_XMLBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity8.XMLBody = HTTPActivity8_XMLBody_Document;
            XmlDocument HTTPActivity8_RequestMultipartInfoXml_Document = new XmlDocument();
            HTTPActivity8_RequestMultipartInfoXml_Document.PreserveWhitespace = true;
            HTTPActivity8_RequestMultipartInfoXml_Document.LoadXml(
@"<RequestMultipartInfo><Type>Related</Type></RequestMultipartInfo>");
            _flow.HTTPActivity8.RequestMultipartInfoXml = HTTPActivity8_RequestMultipartInfoXml_Document;
            _flow.HTTPActivity8.Multipart=false;
            VTDPropertyInfoBase pi55 = new VTDPropertyInfoBase("XMLResponse","/*[local-name(.)='Object'][1]/*[local-name(.)='token_endpoint'][1]");
            VTDBaseGetter binding_getter28 = new VTDJsonGetter(pi55);
            VTDPropertyInfoBase pi56 = new VTDPropertyInfoBase("Url");
            VTDBaseSetter binding_setter28 = new VTDObjectSetter(pi56);
            binding_setter28 = new StringFormaterDecorator(binding_setter28,"{Step.ResponseJsonBody.HTTPActivity6.token_endpoint}");
            bind_dir28 = new BindDirection(_flow.HTTPActivity6,binding_getter28,binding_setter28,BindTargetType.ToInProperty);
            _flow.HTTPActivity8.InDirections.Add(bind_dir28);
            VTDPropertyInfoBase pi57 = new VTDPropertyInfoBase("ExecutionInputParameters","/*[local-name(.)='Arguments'][1]/*[local-name(.)='Proxy'][1]");
            VTDBaseGetter binding_getter29 = new VTDXPathGetter(pi57,XmlTypeCode.String);
            VTDPropertyInfoBase pi58 = new VTDPropertyInfoBase("Proxy.Server");
            VTDBaseSetter binding_setter29 = new VTDObjectSetter(pi58);
            binding_setter29 = new StringFormaterDecorator(binding_setter29,"{Step.OutputProperties.StartActivity1.Proxy}");
            bind_dir29 = new BindDirection(_flow.StartActivity1,binding_getter29,binding_setter29,BindTargetType.ToInProperty);
            _flow.HTTPActivity8.InDirections.Add(bind_dir29);
            XmlDocument HTTPActivity8_ExpectedResponseXmlBody_Document = new XmlDocument();
            HTTPActivity8_ExpectedResponseXmlBody_Document.PreserveWhitespace = true;
            HTTPActivity8_ExpectedResponseXmlBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity8.ExpectedResponseXmlBody = HTTPActivity8_ExpectedResponseXmlBody_Document;
            XmlDocument HTTPActivity8_ExpectedResponseJsonBody_Document = new XmlDocument();
            HTTPActivity8_ExpectedResponseJsonBody_Document.PreserveWhitespace = true;
            HTTPActivity8_ExpectedResponseJsonBody_Document.LoadXml(
@"<Object jsonType=""Object"" isAnonymous=""true""><access_token jsonType=""String"">eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6InlSMTBQQ2JXTGFoQU9LNXl5cU1rMXBseWh4NCIsImtpZCI6InlSMTBQQ2JXTGFoQU9LNXl5cU1rMXBseWh4NCJ9.eyJpc3MiOiJPQXV0aFNlcnZlciIsImF1ZCI6Ik9BdXRoU2VydmVyL3Jlc291cmNlcyIsImV4cCI6MTU3MTE3ODg4MywibmJmIjoxNTcxMTUwMDgzLCJjbGllbnRfaWQiOiJJT01BcHAiLCJzY29wZSI6Iklubm92YXRvciIsInN1YiI6ImFkbWluIiwiYXV0aF90aW1lIjoxNTcxMTUwMDgzLCJpZHAiOiJpZHNydiIsIm5hbWUiOiJhZG1pbiIsInVzZXJuYW1lIjoiYWRtaW4iLCJkYXRhYmFzZSI6IjExU1AxNV9EZW1vIiwiYW1yIjpbInBhc3N3b3JkIl19.Z1TrxfuL9n5Zy9gIu27lOquaNTGyPwlHto3UBGQz6viyDaPJT436KW8XJOA10k0anVEILoLT4QhpgCehZmPQjxogKpukKSvMoh8kq0oBOJdL_BS2Yu7ylCGPZG7NjlnbR39eggZN4Ugnx0PUoQFduR1kthoodfEg9Pet-1ccSAUxivGg10siG2SQ0-q0eokWspF8qAxInvDkc1N5TGakI483HKxRy2vVR2fZRIpikxM4XoIAJgCwHkkmOKSaJGE7z6gFpUkiBAAGp08kGj5tp0kXCYFd4HgQZWeFYqdYftTb5jz1w4eEVIT-FdVi_6RZH3nrCxKog586gYREA2Rn-w</access_token><expires_in jsonType=""Integer"">28800</expires_in><token_type jsonType=""String"">Bearer</token_type></Object>");
            _flow.HTTPActivity8.ExpectedResponseJsonBody = HTTPActivity8_ExpectedResponseJsonBody_Document;
            XmlDocument HTTPActivity8_ExpectedOutputProperties_Document = new XmlDocument();
            HTTPActivity8_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            HTTPActivity8_ExpectedOutputProperties_Document.LoadXml(
@"<Arguments><ResponseHttpVersion /><StatusCode /><StatusDescription /><ResponseBody /><ResponseBodyAsBase64 /></Arguments>");
            _flow.HTTPActivity8.ExpectedOutputProperties = HTTPActivity8_ExpectedOutputProperties_Document;
            _flow.ConcatenateStringsActivity10.Prefix = @"Bearer ";
            _flow.ConcatenateStringsActivity10.Suffix = @"{Step.ResponseJsonBody.HTTPActivity8.access_token}";
            _flow.ConcatenateStringsActivity10.Comment = @"";
            _flow.ConcatenateStringsActivity10.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_concat.png";
            _flow.ConcatenateStringsActivity10.Name = @"GetBearerAccess";
            VTDPropertyInfoBase pi59 = new VTDPropertyInfoBase("XMLResponse","/*[local-name(.)='Object'][1]/*[local-name(.)='access_token'][1]");
            VTDBaseGetter binding_getter30 = new VTDJsonGetter(pi59);
            VTDPropertyInfoBase pi60 = new VTDPropertyInfoBase("Suffix");
            VTDBaseSetter binding_setter30 = new VTDObjectSetter(pi60);
            binding_setter30 = new StringFormaterDecorator(binding_setter30,"{Step.ResponseJsonBody.HTTPActivity8.access_token}");
            bind_dir30 = new BindDirection(_flow.HTTPActivity8,binding_getter30,binding_setter30,BindTargetType.ToInProperty);
            _flow.ConcatenateStringsActivity10.InDirections.Add(bind_dir30);
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    
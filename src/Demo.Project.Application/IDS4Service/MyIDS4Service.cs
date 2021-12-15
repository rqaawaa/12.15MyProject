using Demo.Project.MyInterface;
using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Project.IDS4Service
{
    public  class MyIDS4Service : MyIDS4
    {
        private IConfiguration _configuration;
        public MyIDS4Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<string> GetIdsTokenAsync(string LoginName, string Pwd)
        {
            var client = new HttpClient();
            //ids4访问Url地址
            var idsTokenUrl = _configuration.GetSection("AuthServer:Authority").Value;
            //ids4访问
            var AppClientID = _configuration.GetSection("AuthServer:AppClientID").Value;
            //访问密码
            var AppClientService = _configuration.GetSection("AuthServer:AppClientService").Value;
            var disco = client.GetDiscoveryDocumentAsync(idsTokenUrl);
            var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = disco.Result.TokenEndpoint,
                ClientId=AppClientID,
                ClientSecret=AppClientService,
                UserName=LoginName,
                Password= Pwd
            }) ;
            if(tokenResponse.IsError)
            {
                return string.Empty;
            }
            return tokenResponse.AccessToken;
        }
    }
}

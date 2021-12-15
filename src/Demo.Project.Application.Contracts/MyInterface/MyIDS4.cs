using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Project.MyInterface
{
    public interface MyIDS4
    {
        public Task<string> GetIdsTokenAsync(string LoginName, string Pwd);
    }
}

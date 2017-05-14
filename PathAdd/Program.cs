using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathAdd
{
    static class Program
    {
        static void Main(String[] args)
        {
            if (args.Length != 1)
                return;

            var specifiedPath = args[0].Trim(new char[] { '"', ' '});
            var existingPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User).Trim(new char[] { ';', ' '});

            if(existingPath.Split(';').Contains(specifiedPath))
            {
                MessageBox.Show($"Path already contains \"{ specifiedPath }\"", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var fullString = $"{existingPath};{specifiedPath}".Trim(new char[] { ' ', ';' });

            Environment.SetEnvironmentVariable("Path", fullString, EnvironmentVariableTarget.User);

            MessageBox.Show($"Added \"{ specifiedPath }\" to Path", "Added to Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   interface IRuneterrarian
    {
        string speak(string speak_file_location);
        string dance(string dance_folder_location);
        
    }
interface IAscended
    {
        string Ascend(string ascend_file_location);
    }
    interface IDarkin
    {
        string make_bad_guy_laugh(string laugh_location);
    }



}

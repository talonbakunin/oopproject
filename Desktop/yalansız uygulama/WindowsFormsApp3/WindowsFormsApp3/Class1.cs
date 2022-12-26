using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Runeterrarian : IRuneterrarian
    {
       

        public string dance(string dance_folder_location)
        {
            string dance;
            dance = dance_folder_location;
            return dance;
        }

        public string speak(string speak_file_location)
        {
            string speak;
            speak= speak_file_location;
            return speak;
        }
    }

    public class Ascended : IRuneterrarian, IAscended
    {
        public string dance(string dance_folder_location)
        {
            string dance;
            dance= dance_folder_location;
            return dance;
        }

        public string Ascend(string ascend_file_location)
        {
            string ascend;
            ascend = ascend_file_location;
            return ascend;
            
        }

        public string speak(string speak_file_location)
        {
            string speak;
            speak = speak_file_location;
            return speak;

        }
    }
    public class Darkin : IDarkin, IAscended, IRuneterrarian
    {
        public string dance(string dance_folder_location)
        {
            string dance;
            dance=dance_folder_location;
            return dance;
        }

        public string Ascend(string ascen_fie_location)
        {
            string ascend;
            ascend=ascen_fie_location;
            return ascend;
        }

        public string make_bad_guy_laugh(string laugh_location)
        {
            string laugh;
            laugh=laugh_location;
            return laugh;
        }

        public string speak(string speak_file_location)
        {
            string speak;
            speak = speak_file_location;
            return speak;
        }

       
    }



}

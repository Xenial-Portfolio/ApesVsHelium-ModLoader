using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityEngine;

namespace ModdingPlatformBase.Classes
{
    class Menu : MonoBehaviour
    {
        public static Form MenuForm;
        private static bool isMenuShown;

        public void Start()
        {
            MenuForm = new MenuForm();
            MenuForm.Show();
        }

        public void OnGUI()
        {
            
        }
    }
}

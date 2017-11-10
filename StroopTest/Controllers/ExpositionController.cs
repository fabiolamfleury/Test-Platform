﻿namespace TestPlatform.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TestPlatform.Views;
    using TestPlatform.Views.ExperimentPages;

    public class ExpositionController
    {
        public static string[] ShuffleArray(string[] array, int expectedLength, int rndSeed) // randomiza Vetor - parâmetros: vetor / tamanho esperado do vetor randomizado
        {
            List<string> randomArray = new List<string>();
            Random rnd = new Random(DateTime.Now.Millisecond + expectedLength + rndSeed);

            if (expectedLength == array.Count()) 
            {
                // if there is intent to keep the same vector size, there are no repetitions
                randomArray = array.OrderBy(x => rnd.Next()).ToList();
            }
            else
            {
                // if there is intent to extent vector size it will be filled with random values from the original one, repeting itself
                for (int i = 0; i < expectedLength; i++) 
                {
                    randomArray.Add(array[rnd.Next(array.Length)]);
                }
            }

            return randomArray.ToArray();
        }

        public static void BeginStroopTest(string programName, string participantName, char mark, Form form)
        {
            try
            {
                FormExposition ormExposition = new FormExposition(programName, participantName, mark);
                ormExposition.StartPosition = FormStartPosition.Manual;
                ormExposition.Location = Screen.AllScreens[ShowOnMonitor(form)].WorkingArea.Location;
                SendKeys.SendWait("i");                
                var dialogResult = ormExposition.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void BeginReactionTest(string programName, string participantName, char mark, Form form)
        {
            try
            {
                FormReactExposition reactionExposition = new FormReactExposition(programName, participantName, mark);
                reactionExposition.StartPosition = FormStartPosition.Manual;
                reactionExposition.Location = Screen.AllScreens[ShowOnMonitor(form)].WorkingArea.Location;
                SendKeys.SendWait("i");
                reactionExposition.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void BeginExperimentTest(string programName, string participantName, char mark, Form form)
        {
            try
            {
                FormExperimentExposition experimentExposition = new FormExperimentExposition(programName, participantName, mark);
                experimentExposition.StartPosition = FormStartPosition.Manual;
                experimentExposition.Location = Screen.AllScreens[ShowOnMonitor(form)].WorkingArea.Location;
                SendKeys.SendWait("i");
                experimentExposition.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static int ShowOnMonitor(Form form)
        {
            Screen[] sc;
            sc = Screen.AllScreens;
            int showOnMonitor = 0;
            if (sc.Length > 1)
            {
                if (sc[0].Bounds == Screen.FromControl(form).Bounds)
                {
                    showOnMonitor = 1;
                }

                if (sc[1].Bounds == Screen.FromControl(form).Bounds)
                {
                    showOnMonitor = 0;
                }
            }

            return showOnMonitor;
        }
    }
}

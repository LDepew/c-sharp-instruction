using System;
using System.Collections.Generic;
using System.Text;

namespace Proj12_2_Wizard_Inventory {
    class MyConsole {

        public static String getString(String prompt) {
            Console.Write(prompt);
            String s = Console.ReadLine();  // read user entry
            Console.ReadLine();  // discard any other data entered on the line
            return s;
        }

        public static String getRequiredString(String prompt) {
            String s = "";
            Boolean isValid = false;
            while (!isValid) {
                Console.WriteLine(prompt);
                s = Console.ReadLine();
                if (s.Equals("")) {
                    Console.WriteLine("Error! This entry is required. Try again.");
                } else {
                    isValid = true;
                }
            }
            return s;
        }

        public static String GetChoiceString(String prompt,
        String s1, String s2) {
            String s = "";
            Boolean isValid = false;
            while (!isValid) {
                s = getRequiredString(prompt);
                if (!(s == s1) && !(s == s2)) {
                    Console.WriteLine("Error! Entry must be '" + s1 + "' or '" + s2 + "'. Try again.");
                } else {
                    isValid = true;
                }
            }
            return s;
        }

        public static String getChoiceString(String prompt, String s1, String s2) {
            String s = "";
            Boolean isValid = false;
            while (!isValid) {
                s = getRequiredString(prompt);
                if (!(s == s1) && !(s == s2)) {
                    Console.WriteLine("Error! Entry must be '" + s1 + "' or '" + s2 + "'. Try again.");
                } else {
                    isValid = true;
                }
            }
            return s;
        }

        public static int getInt(String prompt) {
            int i = 0;
            Boolean isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                try {
                    i = Int32.Parse(Console.ReadLine());
                    isValid = true;

                } catch (Exception) {
                    Console.WriteLine("Error! Invalid integer. Try again.");
                }
            }
            return i;
        }




        public static int GetInt(String prompt, int min, int max) {
            int i = 0;
            Boolean isValid = false;
            while (!isValid) {
                i = getInt(prompt);
                if (i <= min) {
                    Console.WriteLine(
                            "Error! Number must be greater than " + min + ".");
                } else if (i >= max) {
                    Console.WriteLine(
                            "Error! Number must be less than " + max + ".");
                } else {
                    isValid = true;
                }
            }
            return i;
        }




    }
}

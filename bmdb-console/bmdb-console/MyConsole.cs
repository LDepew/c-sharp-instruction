using System;
using System.Collections.Generic;
using System.Text;

namespace bmdb_console {
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

            public static String getChoiceString(String prompt,
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

        public static String getChoiceString(String prompt,
            String[] validEntries) {
            String s = "";
            Boolean isValid = false;
            while (!isValid) {
                s = getRequiredString(prompt);
                // loop through all valid entries to see if user entry is valid
                for (String str: validEntries) {
                    if (s == str) {
                        isValid = true;
                        break;
                    }
                }
                // if user did not match then display an error
                if (!isValid)
                    Console.WriteLine("Invalid entry, '" + s + "'. Try again.");
            }
            return s;
        }

        public static int getInt(String prompt) {
            int i = 0;
            Boolean isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                try {
                    i = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                } catch (Exception e) {
                    Console.WriteLine("Error! Invalid integer. Try Again");
                }
                return i;
            }
        }

    


            public static int getInt(String prompt, int min, int max) {
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


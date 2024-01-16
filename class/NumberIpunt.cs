class UserInputs { 

    public static string PersonNummerInput() { 

        Write("\n\n\t\tSkriv in ett personnummer: ");

            try {

                string personNummerInput = ReadLine();
                if(!string.IsNullOrWhiteSpace(personNummerInput)) {
                    return personNummerInput;
                }
                else 
                    throw new FormatException();

            }
            catch (FormatException) {
                WriteLine("\n\n\t\tInvalid Input!");
                return null;
             }
            
    }

}

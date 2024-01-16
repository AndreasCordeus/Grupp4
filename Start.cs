class HereWeGo { 

    public static void Start() { 

        bool mainLoop = true;
        while (mainLoop) { 


            string? personNummer = UserInputs.SocialSecurityNumberInput();

            LastNumberCalculation.TestSocialSecurityNumber(personNummer);

        }
    }
}
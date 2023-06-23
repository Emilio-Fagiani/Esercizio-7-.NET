using System;
public class Class
{
    static void Main(string[] args)
    {
        Class2 class2 = new Class2();


        // Accesso ai membri privati
        //  Class2.privateVariable = 10;
        //  Class2.PrivateMethod();
        // 'Class2.privateVariable' non è accessibile a causa del livello di protezione
        // 'Class2.PrivateMethod()' non è accessibile a causa del livello di protezione

        // Accesso ai membri protetti
        // Class2.protectedVariable = 20;
        // Class2.ProtectedMethod();
        // 'Class2.protectedVariable' non è accessibile a causa del livello di protezione
        // 'Class2.ProtectedMethod()' non è accessibile a causa del livello di protezione

        // Accesso ai membri interni
            class2.internalVariable = 30;
            class2.InternalMethod();

        // Accesso ai membri pubblici
            class2.publicVariable = 40;
            class2.PublicMethod();
    }
}


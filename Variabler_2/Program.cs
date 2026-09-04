// ==============================
// VARIABLES
// ==============================

// Variables (variabler) - en behållare för att lagra data av en viss typ.

// I C# måste variabler deklareras innan de kan användas.
// Syntax för deklaration av variabel:
// [Datatyp] [Identifier]

int x;
int y = 3;
double z = 3.45;
char letterA = 'A';         // Char literal values omges av single quotes '
string name = "Fredrik";    // String literal values omges av double quotes "
bool isEnabled = true;


// ==============================
// LITERAL VALUES
// ==============================

// Literal values - hårdkodade värden direkt i koden.
// Exempel:
// 3
// 3.35
// 'A'
// "Fredrik"
// true

// Literal values kan använda suffix för att ange vilken typ värdet ska ha.
//
// Exempel:
// 1.0f är ett float-värde
// 1.0 är ett double-värde


// ==============================
// DATA TYPES
// ==============================

// Data types (datatyper) - anger vilken typ av data vi lagrar,
// till exempel i en variabel.

// byte b = 300;
// Exempel på ett värde som ligger utanför datatypens tillåtna range.

short s = 300;

// byte b = -100;
// byte är en UNSIGNED integer och kan därför inte lagra negativa tal.

sbyte sb = -100;


// ==============================
// STATIC TYPING
// ==============================

// C# är ett statiskt typat språk.
//
// Det betyder att datatypen för varje variabel måste vara känd
// innan koden kompileras.


// ==============================
// STRONG TYPING
// ==============================

// C# är ett starkt typat språk.
//
// Om man försöker tilldela ett värde av fel typ till en variabel
// resulterar det i ett kompileringsfel.

// name = 3;


// ==============================
// TYPE SAFETY
// ==============================

// C# är ett typsäkert språk.
//
// Man kan bara utföra operationer som den givna datatypen tillåter.

Console.WriteLine(y + 3);

// Console.WriteLine(isEnabled + 3);
// Otillåten operation mellan bool och int.


// ==============================
// EXPLICIT AND IMPLICIT TYPING
// ==============================

// Explicit = uttryckligen
// Implicit = underförstått

// Explicit typad variabel:
// Vi har uttryckligen angett att datatypen på myInt är int.

int myInt;

// Implicit typad variabel:
// Med keyword 'var' avgör kompilatorn datatypen
// utifrån värdet som variabeln får direkt vid deklarationen.

var myVariable = 3.24f;


// ==============================
// SCOPE
// ==============================

// Scope - anger var i koden en variabel kan användas.
//
// Vanliga nivåer:
// - Class scope
// - Method scope
// - Block scope

bool myBool = true;

if (isEnabled)
{
    bool myOtherBool = true;

    if (true)
    {
        bool myThirdBool = true;

        Console.WriteLine(myBool);
        Console.WriteLine(myOtherBool);
        Console.WriteLine(myThirdBool);
    }

    if (true)
    {
        bool myThirdBool = true;

        Console.WriteLine(myBool);
        Console.WriteLine(myOtherBool);
        Console.WriteLine(myThirdBool);
    }

    Console.WriteLine(myBool);
    Console.WriteLine(myOtherBool);

    // myThirdBool finns inte här eftersom den deklarerades
    // inne i de mindre if-blocken.
    // Console.WriteLine(myThirdBool);
}

Console.WriteLine(myBool);

// myOtherBool finns inte här eftersom den deklarerades
// inne i det yttre if-blocket.
// Console.WriteLine(myOtherBool);

// myThirdBool finns inte heller här.
// Console.WriteLine(myThirdBool);
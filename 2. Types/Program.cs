Console.WriteLine("---- Types in C# ----");
const int rowWidth = -15;


int integerNumber = 3;
Type integerNumberType = integerNumber.GetType();
Console.WriteLine($"Data: {integerNumber, rowWidth}  ||  is of type {integerNumberType, rowWidth}  ||  and allocates size in memory of {sizeof(int),rowWidth}");

long longNumber = 3425L;
Type longNumberType = longNumber.GetType();
Console.WriteLine($"Data: {longNumber,rowWidth}  ||  is of type {longNumberType,rowWidth}  ||  and allocates size in memory of {sizeof(long),rowWidth}");

float floatNumber = 15.242F;
Type floatNumberType = floatNumber.GetType();
Console.WriteLine($"Data: {floatNumber,rowWidth}  ||  is of type {floatNumberType,rowWidth}  ||  and allocates size in memory of {sizeof(float),rowWidth}");

double doubleNumber = 162.51236342D;
Type doubleNumberType = doubleNumber.GetType();
Console.WriteLine($"Data: {doubleNumber,rowWidth}  ||  is of type {doubleNumberType,rowWidth}  ||  and allocates size in memory of {sizeof(double),rowWidth}");

bool booleanValue = true;
Type booleanValueType = booleanValue.GetType();
Console.WriteLine($"Data: {booleanValue,rowWidth}  ||  is of type {booleanValueType,rowWidth}  ||  and allocates size in memory of {sizeof(bool),rowWidth}");

char charValue = 'w';
Type charValueType = charValue.GetType();
Console.WriteLine($"Data: {charValue,rowWidth}  ||  is of type {charValueType,rowWidth}  ||  and allocates size in memory of {sizeof(char),rowWidth}");

string stringValue = "Example String";
Type stringValueType = stringValue.GetType();
Console.WriteLine($"Data: {stringValue,rowWidth}  ||  is of type {stringValueType,rowWidth}  ||  and allocates size in memory depending of size of a string");


Console.ReadLine();

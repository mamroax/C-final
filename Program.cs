String[] myArray = {"Russia", "Denmark", "Kazan"};

int number = 3;

int myArrayLen = myArray.Length;
String[] result = new String[myArrayLen];
int counter = 0;

for (int i = 0; i < myArray.Length; i++)    {
    if (myArray[i].Length <= number){
        result[counter] = myArray[i];
        counter++;
    }
}

for (int i = 0; i < result.Length; i++){
    Console.Write(result[i]  + " ");
}


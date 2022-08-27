namespace DZ6
{
    public class dz
    {
        //Задача 41
        public int FindNumberMoreZero(string[] inputString)
        {
            int countNumberMoreZero = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                inputString[i] = inputString[i].Replace(".", ",");
                if (double.TryParse(inputString[i], out double value))
                {
                    Console.Write($"{value}");
                    if (i < inputString.Length-1) Console.Write(", ");
                    if (value > 0) countNumberMoreZero++;
                }

            }
            return countNumberMoreZero;
        }

        //Задача 43
        public string FindIntersectionPointLine(string[] inputString)
        {
            double b1=0,k1=0,b2=0,k2=0;
            if (inputString.Length==0) return "No correct Input number!";
            for (int i = 0; i < inputString.Length; i++)
            {
                inputString[i] = inputString[i].Replace(".", ",");
                if (double.TryParse(inputString[i], out double value))
                {
                    switch (i)
                    {
                        case 0: b1 = value; break;
                        case 1: k1 = value; break;
                        case 2: b2 = value; break;
                        case 3: k2 = value; break;
                    }

                }
                else
                {
                    return "No correct Input number!";
                }
            }
            if (k1 == k2) return "Line in paralel! Point not found!";
            else return "b1 = " + b1.ToString() + ",k1 = " + k1.ToString() + ",b2 = " +
                 b2.ToString() + ",k2 = " + k2.ToString() +" -> (" + ((b2 - b1) / (k1 - k2)).ToString()+
                 ";"+(k1* ((b2 - b1) / (k1 - k2))+b1).ToString()+")";
        }
    }
}
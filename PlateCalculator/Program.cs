
namespace plateNamespace
{
    class PlateCalc
    {
       public static void Main(string[] args)
        {
            PlateCalc plateCalc= new PlateCalc();

            Console.WriteLine("(plate1 - plate2)");
            Console.WriteLine("Enter number plate 1: ");
            String ?plate1 = Console.ReadLine();
            Console.WriteLine("Enter number plate 2: ");
            String ?plate2 = Console.ReadLine();

            

            int difference = plateCalc.toInt(plate1) - plateCalc.toInt(plate2);
            Console.WriteLine($"difference is: {difference}");
        }


        private int toInt(String plate) 
        {
            // remove any black splaces and  conver to upper case
            plate = plate.Replace(" ","");
            plate= plate.ToUpper();


           
            int second = letterToInt(plate[1]);
            int third = letterToInt(plate[2]);
            int digits = Convert.ToInt16(string.Join("", plate.Skip(3).Take(3).ToArray()));
            int seven = plate[6];

            
            int total = (((second - 1) * 675324) + ((third - 1) * 25974) + ((seven - 1) * 999) + digits );

            return total;
        }

        private int letterToInt(char c)
        {
            Dictionary<Char,int> map = new Dictionary<Char, int>()
            {
                { 'A', 1 },
                { 'B', 2 },
                { 'C', 3 },
                { 'D', 4 },
                { 'E', 5 },
                { 'F', 6 },
                { 'G', 7 },
                { 'H', 8 },
                { 'I', 9 },
                { 'J', 10 },
                { 'K', 11 },
                { 'L', 12 },
                { 'M', 13 },
                { 'N', 14 },
                { 'O', 15 },
                { 'P', 16 },
                { 'Q', 17 },
                { 'R', 18 },
                { 'S', 19 },
                { 'T', 20 },
                { 'U', 21 },
                { 'V', 22 },
                { 'W', 23 },
                { 'X', 24 },
                { 'Y', 25 },
                { 'Z', 25 },
              
            };

            int i;
             
            if(map.TryGetValue(c, out i))
            {
                return i;
            }
            else
            {
                throw new Exception(message: "Not a char");
            }

            
        }

    }
}
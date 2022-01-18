namespace dele
{
    internal class ProgramBase
    {
        public static Dictionary<string, string> MergeDictionary(Dictionary<string, string> dict1, Dictionary<string, string> dict2)
        {
            foreach (var thing in dict1)
            {
                dict2.Add(thing.Key);//make it do something with Add. 
                dict2.Add(thing.Value);//here i am trying to make it add the key and the value, but i have no idea how. 
            }
        }
    }
}
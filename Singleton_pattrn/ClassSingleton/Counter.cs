namespace Singleton_pattrn.ClassSingleton
{
    public class Counter
    {
        private List<string> Count { get; set; } 

        // To Make Lock To sure No More Instance done on that class
        private static object _LockObject=new object();
        //Decleration For Instance Use
        private static Counter _instance;
        //To Prevent Instanse From This Class
        private Counter()
        {

        }
        public static Counter GetInstance()
        {
            //the double-checked locking 
            if (_instance == null)
            {
                lock (_LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Counter();
                    }
                }
            }
            return _instance;

        }
        //Use same Instace
        public List<string> LoadData()
        {
            //declare property Count in this Class
            var instanceCount = _instance.Count;
            //Check If Havent Data To Add Initial Data
            if (_instance.Count==null)
            {
                instanceCount = _instance.Count = new List<string>()
                {
                   "shimaa","moax"
                };
             }
        
            return instanceCount;
        }

        public List<string> AddData()
        {
            //Get Data In object And Add New
            var getData=  LoadData();
            List<string> AddedData = new List<string>()
            {
                "Sameha","Ayoub"
            };
            getData.AddRange(AddedData);
            return getData;
        }
    }
}

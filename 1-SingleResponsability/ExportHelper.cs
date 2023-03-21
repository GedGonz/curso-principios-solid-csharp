using System.Linq;
namespace SingleResponsability
{
    public class ExportHelper{
        public void ExportStudent<T>(IEnumerable<T> students)
        {
            var properties = String.Join(";",typeof(T).GetProperties().Select(x=>x.Name).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(properties);
            foreach (var item in students)
            {
                    string val=string.Empty;
                    
                    item.GetType().GetProperties().ToList().ForEach(x=>{
                    var values=item.GetType().GetProperty(x.Name).GetValue(item);
                    val+=(values.GetType().Name != typeof(List<>).Name?$"{values};":String.Join("|", (List<double>)values));
                    });
                  sb.AppendLine(val);
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), System.Text.Encoding.Unicode);
        }
    }
}
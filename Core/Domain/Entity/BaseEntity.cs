using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public BaseEntity()//constracture sor-Bu clas tetiklendiğinde bir kere olmak üzere otomatik çalıştır metodu
        {
            CreateDate = DateTime.Now;

        }
    }
}

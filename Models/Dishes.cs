//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Dishes
    {
        public int DishesId { get; set; }
        public string DishesName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> CategoryId { get; set; }    
        public virtual DishesCategory DishesCategory { get; set; }

        //非EF映射属性，后台执行操作的时候，该NotMapped特性，会告诉ORM框架，该属性参与
        [NotMapped]
        public string DishesImg
        {
            get { return this.DishesId.ToString() + ".png"; }
        }
    }
}

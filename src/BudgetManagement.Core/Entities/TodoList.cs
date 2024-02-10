using BudgetManagement.Core.Common;
using System;
using System.Collections.Generic;

namespace BudgetManagement.Core.Entities
{
    public class TodoList : BaseEntity, IAuditedEntity
    {
        public string Title { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public List<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}

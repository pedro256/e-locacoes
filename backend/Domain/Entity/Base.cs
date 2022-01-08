using System.Collections.Generic;

namespace Domain.Entity{
    public abstract class Base{
        public long Id { get; set; }

        internal List<string> _errors;
        public IReadOnlyCollection<string> Errors => _errors;

        public abstract bool Validate();
    }
}
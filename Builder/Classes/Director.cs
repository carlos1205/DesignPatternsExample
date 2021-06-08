using Builder.Interfaces;

namespace Builder.Classes
{
    class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }
        
        public void BuildMinimalViableProduct()
        {
            this._builder.BuilderPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuilderPartA();
            this._builder.BuilderPartB();
            this._builder.BuilderPartC();
        }
    }
}

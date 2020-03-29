using NancyDemo.API;

namespace NancyHelloWorld
{
    using Nancy;
    using Nancy.ModelBinding;

    public class HomeModule : NancyModule
    {
        public HomeModule() : base("/Home")
        {

            Post("/", args =>
            {
                var person = this.BindAndValidate<Person>();

                if (!this.ModelValidationResult.IsValid)
                {
                    return 422;
                }

                return person;
            });


            Get("Home/{name}", args =>
            {
                new Person() { Name = args.name };

                return true;
            });




            Put("/{userId:int}", parameters => parameters);


            Delete("/{userId:int}", parameters => parameters);



        }
    }
}

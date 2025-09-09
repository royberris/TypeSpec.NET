import "@typespec/http";
import "@typespec/rest";
import "@typespec/openapi3";
import "@typespec/versioning";

using TypeSpec.Http;
using TypeSpec.Versioning;

@service({
  title: "Weather API",
})
@route("/api/weather")
@versioned(Versions)
namespace Weather {
    enum Versions {
        "v1"
    }

    model WeatherResult {
        name: string;
        city?: string;
        givenDate?: plainDate;
    }

    @get
    @route("/weather")
    op getWeather(@query location: string, @query date?: plainDate, @query time: plainTime): {
        @statusCode statusCode: 200;
        @body result: WeatherResult;
    };

    @post
    @route("/weather/news")
    op createNews(@query name: string): {
        @statusCode statusCode: 200;
        @body result: string;
    };
}
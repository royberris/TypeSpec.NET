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
        givenDate?: plainDate;
    }

    @get
    @route("/weather")
    op getWeather(@query location: string, @query date?: plainDate): {
        @statusCode statusCode: 200;
        @body result: WeatherResult;
    };
}
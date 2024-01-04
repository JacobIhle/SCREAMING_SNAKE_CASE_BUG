Default WeatherForecast API in .NET 6 and .NET 8 used as an example to demonstrate unusual casing on responses returned with API in ASP.NET when the attributes for a model are in SCREAMING_SNAKE_CASE.

Instead of either returning the same casing, or chaning it to a known casing standard, like for example regular_snake_case, it makes all letters of the first word, except the last on, lowercase, but keep the rest of the attribute as uppercase.
So SCREAMING_SNAKE_CASE becomes screaminG_SNAKE_CASE
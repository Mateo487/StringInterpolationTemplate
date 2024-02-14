using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    // 1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    // 2. 2019.01.22
    public string Number02()
    {
        throw new NotImplementedException();
    }

    // 3. Day 22 of January, 2019
    public string Number03()
    {
        throw new NotImplementedException();
    }

    // 4. Year: 2019, Month: 01, Day: 22
    public string Number04()
    {
        throw new NotImplementedException();
    }

    // 5.            Tuesday (10 spaces total, right aligned)
    public string Number05()
    {
        throw new NotImplementedException();
    }

    // 6.     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
    public string Number06()
    {
        throw new NotImplementedException();
    }

    // 7. h:11, m:01, s:27
    public string Number07()
    {
        throw new NotImplementedException();
    }

    // 8. 2019.01.22.11.01.27
    public string Number08()
    {
        throw new NotImplementedException();
    }

    // Output Math.PI as currency
    public string Number09()
    {
        throw new NotImplementedException();
    }

    // Output Math.PI as right-aligned (10 spaces), number with 3 decimal places
    public string Number10()
    {
        throw new NotImplementedException();
    }

    // Output the year (2019) as a hexidecimal value
    public string Number11()
    {
        throw new NotImplementedException();
    }
}

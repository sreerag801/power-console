using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace PowerConsole.Services
{
    public interface IRunService
    {
        void Run();
    }

    public class RunService : IRunService
    {
        private readonly ILogger<RunService> _Logger;
        private readonly IConfiguration _Config;

        public RunService(ILogger<RunService> logger, IConfiguration config)
        {
            _Logger = logger;
            _Config = config;
        }

        public void Run()
        {
            int loopTime = Convert.ToInt32(_Config.GetSection("LoopTime").Value);
            for (int i = 0; i < loopTime; i++)
            {
                _Logger.LogInformation($"Run number - {i}");
            }
        }
    }
}

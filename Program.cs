using System.Diagnostics;
using Telegram.Bot;
using Telegram.Bot.Extensions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

using System;
using System.Threading.Tasks;

using Quartz;
using Quartz.Impl;

namespace EventsPlannerBot
{
	public class Program
	{
		private static async Task Main(string[] args)
		{
			var botManager = new Manager();
			await botManager.LaunchBot();
		}
	}
}

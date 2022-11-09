﻿using Telegram.Bot.Types.ReplyMarkups;

namespace BottApp.Host.Keyboards;

public static class Keyboard
{
    
    public static InlineKeyboardMarkup MainKeyboardMarkup = new(
        new[]
        {
            // first row
            new []
            {
                InlineKeyboardButton.WithCallbackData("Votes", "ButtonVotes"),
                InlineKeyboardButton.WithCallbackData("Request contact", "ButtonRequestContact"),
            },
            // second row
            new []
            {
                InlineKeyboardButton.WithCallbackData("Help", "ButtonHelp"),
            },
        });
    
    public static InlineKeyboardMarkup VotesKeyboardMarkup = new(
        new[]
        {
            // first row
            new []
            {
                InlineKeyboardButton.WithCallbackData("<", "ButtonLeft"),
                InlineKeyboardButton.WithCallbackData(">", "ButtonRight"),
            },
            // second row
            new []
            {
                InlineKeyboardButton.WithCallbackData("Like", "ButtonLike"),
            },
            // third row
            new []
            {
                InlineKeyboardButton.WithCallbackData("Back", "ButtonBack"),
                InlineKeyboardButton.WithCallbackData("Help", "ButtonHelp"),
            },
        });
    
    
   public static ReplyKeyboardMarkup RequestLocationAndContactKeyboard = new(
        new[]
        {
            KeyboardButton.WithRequestContact("Поделиться контактом"),})
           // KeyboardButton.WithRequestLocation("Location"),})

    {
        ResizeKeyboard = true,
        //OneTimeKeyboard = true
    };
        
       
    
    
    public const string usage = "Usage:\n" +
                         "/votes       - send votes keyboard\n" +
                         "/keyboard    - send custom keyboard\n" +
                         "/remove      - remove custom keyboard\n" +
                         "/photo       - send a photo\n" +
                         "/request     - request location or contact\n" +
                         "/inline_mode - send keyboard with Inline Query\n" +
                         "/help        - Раздел в разработке";
}
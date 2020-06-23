﻿using SereneApi.Interfaces.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SereneApi.Types.Content
{
    public readonly struct FormUrlEncodedContent: IApiRequestContent
    {
        public List<KeyValuePair<string, string>> Content { get; }

        public FormUrlEncodedContent(Dictionary<string, string> content)
        {
            Content = content.ToList();
        }

        public object GetContent()
        {
            return new System.Net.Http.FormUrlEncodedContent(Content);
        }

        public override bool Equals(object obj)
        {
            if(!(obj is FormUrlEncodedContent content))
            {
                return false;
            }

            return Content == content.Content;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Content);
        }
    }
}
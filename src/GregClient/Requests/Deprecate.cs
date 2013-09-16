﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace Greg.Requests
{
    public class Deprecate : PackageReferenceRequest
    {
        public Deprecate(string id)
        {
            this._type = PackageReferenceStyle.Id;
            this._id = id;
        }

        public Deprecate(string name, string engine)
        {
            this._type = PackageReferenceStyle.EngineAndName;
            this._engine = engine;
            this._name = name;
        }

        public override string Path
        {
            get
            {
                if (this._type == PackageReferenceStyle.Id)
                {
                    return "deprecate/" + this._id;
                }
                else
                {
                    return "deprecate/" + this._engine + "/" + this._name;
                } 
            }
        }

        public override Method HttpMethod
        {
            get { return Method.PUT; }
        }

        public override void Build(ref RestRequest request)
        {

        }
    }
}

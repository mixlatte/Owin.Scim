﻿namespace Owin.Scim.Tests.Integration.Groups.Delete
{
    using System.Net;
    using Machine.Specifications;

    public class with_invalid_id : when_deleting_a_group
    {
        /// <summary>
        /// Must have a pre-existing group with members in it
        /// </summary>
        private Establish context = () =>
        {
            GroupId = "bogus id";
        };

        It should_return_not_found = () => Response.StatusCode.ShouldEqual(HttpStatusCode.NotFound);
    }
}
﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Orchard.ContentManagement.Metadata.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace Orchard.ContentTypes.ViewModels
{
    public class AddFieldViewModel
    {
        public AddFieldViewModel()
        {
            Fields = new List<Type>();
        }

        /// <summary>
        /// The technical name of the field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The display name of the field
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The selected field type
        /// </summary>
        [Required]
        public string FieldTypeName { get; set; }

        /// <summary>
        /// The part to add the field to
        /// </summary>
        [BindNever]
        public ContentPartDefinition Part { get; set; }

        /// <summary>
        /// List of the available Field types
        /// </summary>
        [BindNever]
        public List<Type> Fields { get; set; }
    }
}
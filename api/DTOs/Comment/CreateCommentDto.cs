using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 characters at least.")]
        [MaxLength(20, ErrorMessage ="Title cannot be over 20 characters!")]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        [MinLength(10, ErrorMessage = "Content must be 10 characters at least.")]
        [MaxLength(150, ErrorMessage ="Content cannot be over 150 characters!")]
        public string Content { get; set; } = string.Empty;
    }
}
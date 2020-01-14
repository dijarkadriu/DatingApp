using System;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.DTOs
{
    public class UserForDetailedDTO
    {
        public UserForDetailedDTO()
        {

        }
        public UserForDetailedDTO(int id, string username, string gender, int age, string knownAs, DateTime created, DateTime lastActive, string city, string country, string introduction, string lookingFor, string interests, string photoUrl)
        {
            this.Id = id;
            this.Username = username;
            this.Gender = gender;
            this.Age = age;
            this.KnownAs = knownAs;
            this.Created = created;
            this.LastActive = lastActive;
            this.City = city;
            this.Country = country;
            this.Introduction = introduction;
            this.LookingFor = lookingFor;
            this.Interests = interests;
            this.PhotoUrl = photoUrl;

        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public ICollection<PhotosForDetailedDTO> Photos { get; set; }
        public string PhotoUrl { get; set; }
    }
}
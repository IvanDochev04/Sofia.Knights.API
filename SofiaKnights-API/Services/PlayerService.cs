using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using SofiaKnights_API.DTOs;
using SofiaKnights_API.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace SofiaKnights_API.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IRepository<Player> playersRepository;

        public PlayerService(IRepository<Player> playersRepository)
        {
            this.playersRepository = playersRepository;
        }
        public List<PlayerListDTO> GetPlayersList()
        {
            var players = this.playersRepository.GetAll();
            var playerList = new List<PlayerListDTO>();
            foreach (var player in players)
            {
                var playerDTO = new PlayerListDTO()
                {
                    Id = player.Id,
                    FullName = player.FullName,
                    Nationality = player.Nationality,
                    ProfilePictureUrl = player.ProfilePictureUrl
                };
                playerList.Add(playerDTO);
            }
            return playerList;
        }

        public PlayerDTO GetPlayerById(int id)
        {
            var player = this.playersRepository.GetById(id);

            var playerDTO = new PlayerDTO()
            {
                Id = player.Id,
                FullName = player.FullName,
                NickName = player.NickName,
                BirthDay = player.BirthDay.Date.ToString("d"),
                Nationality = player.Nationality,
                SelfDiscription = player.SelfDiscription,
                Height = player.PlayerInfo.Height,
                Weight = player.PlayerInfo.Weight,
                Positions = player.PlayerInfo.Positions,
                Number = player.PlayerInfo.Number,
                ProfilePictureUrl = player.ProfilePictureUrl,

            };
            return playerDTO;

        }


        public int CreatePlayer(PlayerDTO playerDTO)
        {

            var player = new Player()
            {
                FullName = playerDTO.FullName,
                NickName = playerDTO.NickName,
                BirthDay = DateTime.Parse(playerDTO.BirthDay),
                Nationality = playerDTO.Nationality,
                SelfDiscription = playerDTO.SelfDiscription,

                ProfilePictureUrl = playerDTO.ProfilePictureUrl,
            };
            var details = new PlayerInfo
            {
                Height = playerDTO.Height,
                Weight = playerDTO.Weight,
                Positions = playerDTO.Positions,
                Number = playerDTO.Number,
            };
            player.PlayerInfo = details;
            var createdPlayer = this.playersRepository.Create(player);
            return createdPlayer.Id;

        }
        public int UpdatePlayer(PlayerDTO playerDTO)
        {

            var player = this.playersRepository.GetById(playerDTO.Id);

            
            player.FullName = playerDTO.FullName;
            player.NickName = playerDTO.NickName;
            player.BirthDay = DateTime.Parse(playerDTO.BirthDay);
            player.Nationality = playerDTO.Nationality;
            player.SelfDiscription = playerDTO.SelfDiscription;
            player.PlayerInfo.Height = playerDTO.Height;
            player.PlayerInfo.Weight = playerDTO.Weight;
            player.PlayerInfo.Positions = playerDTO.Positions;
            player.PlayerInfo.Number = playerDTO.Number;
            player.ProfilePictureUrl = playerDTO.ProfilePictureUrl;
            var updatedPlayer = this.playersRepository.Update(player);
            return updatedPlayer.Id;
        }
        public void DeletePlayer(int id) 
        {
            this.playersRepository.Delete(id);
        }
    }
}

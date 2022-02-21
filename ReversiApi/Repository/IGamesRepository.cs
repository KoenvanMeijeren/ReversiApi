﻿using ReversiApi.Model.Game;

namespace ReversiApi.Repository;

/// <summary>
/// Provides an interface for games repository.
/// </summary>
public interface IGamesRepository
{
    /// <summary>
    /// Adds a new game to the repository.
    /// </summary>
    /// <param name="game">The game.</param>
    void Add(IGame game);

    /// <summary>
    /// Returns all games of the repository.
    /// </summary>
    /// <returns>The games.</returns>
    List<IGame> All();

    /// <summary>
    /// Returns all games of the queue.
    /// </summary>
    /// <returns></returns>
    IEnumerable<IGame> AllInQueue();

    /// <summary>
    /// Determines if the game exists.
    /// </summary>
    /// <param name="token">The unique token of the game.</param>
    /// <returns>Whether the game exists or not.</returns>
    bool Exists(string? token);
    
    /// <summary>
    /// Gets the game by the token.
    /// </summary>
    /// <param name="token">The unique token of the game.</param>
    /// <returns>The game.</returns>
    IGame? Get(string? token);
    
    /// <summary>
    /// Gets the game by the token of player one.
    /// </summary>
    /// <param name="token">The unique token of the game.</param>
    /// <returns>The game.</returns>
    IGame? GetByPlayerOne(string? token);
    
    /// <summary>
    /// Gets the game by the token of player two.
    /// </summary>
    /// <param name="token">The unique token of the game.</param>
    /// <returns>The game.</returns>
    IGame? GetByPlayerTwo(string? token);
}
using System.Data;
using Xunit;
using System;
using System.Diagnostics;
using DomainPrimitives;


namespace DTO.Tests;

public class FirstnameTest
{
    [Fact]
    public void Nameisvalidlength_noexception()
    {

        var validName = "John";
        var exception = Record.Exception(() => new FirstName(validName));
        Assert.Null(exception);
    }
    [Fact]
    public void Nameisvalidregex_noexception()
    {
        var validName = "John";
        var exception = Record.Exception(() => FirstName.IsFirstNameValidRegex(validName));
        Assert.Null(exception);
    }
    [Fact]
    public void NameIsInvalidLength_ThrowsException()
    {
        var invalidName = "a";
        Assert.Throws<ArgumentException>(() => FirstName.IsFirstNameValidLength(invalidName));
    }
        [Fact]
    public void NameIsInvalidRegex_ThrowsException()
    {
        var invalidName = "123!ASDFASDASFASDASFASD";
        Assert.Throws<ArgumentException>(() => FirstName.IsFirstNameValidRegex(invalidName));
    }
}
Imports System.Runtime.InteropServices

<AttributeUsageAttribute(AttributeTargets.Class Or AttributeTargets.Struct Or AttributeTargets.Enum Or AttributeTargets.Delegate, Inherited:=False)> _
<ComVisibleAttribute(True)> _
Public Class Player
    Private m_HP As Integer
    Private m_maxHP As Integer
    Private m_maxMana
    Private m_Mana As Integer
    Private m_EXP As Integer
    Private m_Profession As Profession
    Private m_AttackSkill As Integer
    Private m_MagicSkill As Integer
    Private m_DefenseSkill As Integer
    Private m_MagicDefenseSkill As Integer
    Private m_Level As Integer
    Private m_Name As String
    Private m_Gender As String
#Region "EQ"
    Private m_Helmet As Integer
    Private m_Armor As Integer
    Private m_Legs As Integer
    Private m_Shield As Integer
    Private m_Boots As Integer
    Private m_Amulet As Integer
    Private m_Ring As Integer
    Private m_Weapon As Integer
#End Region
    Public Enum Profession
        Wizard
        Cleric
        Archer
        Warrior
        None
    End Enum

    Public Property HP As Integer
        Get
            Return m_HP
        End Get
        Set(value As Integer)
            m_HP = value
        End Set
    End Property

    Public Property maxHP As Integer
        Get
            Return m_maxHP
        End Get
        Set(value As Integer)
            m_maxHP = value
        End Set
    End Property

    Public Property maxmana As Integer
        Get
            Return m_maxMana
        End Get
        Set(value As Integer)
            m_maxMana = value
        End Set
    End Property

    Public Property mana As Integer
        Get
            Return m_Mana
        End Get
        Set(value As Integer)
            m_Mana = value
        End Set
    End Property

    Public Property exp As Integer
        Get
            Return m_EXP
        End Get
        Set(value As Integer)
            m_EXP = value
        End Set
    End Property

    Public Property prof As Profession
        Get
            Return m_Profession
        End Get
        Set(value As Profession)
            m_Profession = value
        End Set
    End Property

    Public Property name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    Public Property attackskill As Integer
        Get
            Return m_AttackSkill
        End Get
        Set(value As Integer)
            m_AttackSkill = value
        End Set
    End Property

    Public Property magicskill As Integer
        Get
            Return m_MagicSkill
        End Get
        Set(value As Integer)
            m_MagicSkill = value
        End Set
    End Property

    Public Property defenseskill As Integer
        Get
            Return m_DefenseSkill
        End Get
        Set(value As Integer)
            m_DefenseSkill = value
        End Set
    End Property

    Public Property magicdefenseskill As Integer
        Get
            Return m_MagicDefenseSkill
        End Get
        Set(value As Integer)
            m_MagicDefenseSkill = value
        End Set
    End Property

    Public Property lvl As Integer
        Get
            Return m_Level
        End Get
        Set(value As Integer)
            m_Level = value
        End Set
    End Property

    Public Property gender As String
        Get
            Return m_Gender
        End Get
        Set(value As String)
            m_Gender = value
        End Set
    End Property

    Public Sub New(Name As String, gender As String)
        m_Name = Name
        m_Gender = gender
        m_Helmet = 1
        m_Armor = 1
        m_Legs = 1
        m_Boots = 1
        m_Weapon = 1
        m_Profession = Profession.None
        m_HP = 30
        m_Mana = 10
        m_AttackSkill = 5
        m_MagicSkill = 5
        m_DefenseSkill = 5
        m_MagicDefenseSkill = 5
        m_Level = 1
    End Sub
End Class

Public Class Enemy
    Private m_baseAtk As Integer
    Private m_baseDef As Integer
    Private m_baseMD As Integer
    Private m_baseHP As Integer
    Private m_curHP As Integer
    Private m_baseMagic As Integer
    Private m_Target As Boolean
    Private m_ID As Integer
    Private m_Name As String
    Private m_dead As Boolean

    Public Sub New()
        Dim r As New Random
        m_baseAtk = 5
        m_baseDef = 5
        m_baseMD = 5
        m_baseHP = 50
        m_baseMagic = 5
        m_curHP = 50
        m_ID = r.Next(0, 100000)
        m_Target = False
        m_Name = "Banana"
    End Sub

    Public Sub New(name As String, basemagic As Integer, basehp As Integer, basemd As Integer, basedef As Integer, baseatk As Integer)
        m_Name = name
        m_baseMagic = basemagic
        m_curHP = basehp
        m_baseHP = basehp
        m_baseMD = basemd
        m_baseDef = basedef
        m_baseAtk = baseatk
        Dim r As New Random
        m_ID = r.Next(0, 100000)
    End Sub

    Public Property dead As Boolean
        Get
            Return m_dead
        End Get
        Set(value As Boolean)
            m_dead = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    Public Property baseDef As Integer
        Get
            Return m_baseDef
        End Get
        Set(value As Integer)
            m_baseDef = value
        End Set
    End Property

    Public Property baseMagic As Integer
        Get
            Return m_baseMagic
        End Get
        Set(value As Integer)
            m_baseMagic = value
        End Set
    End Property

    Public Property baseMD As Integer
        Get
            Return m_baseMD
        End Get
        Set(value As Integer)
            m_baseMD = value
        End Set
    End Property

    Public Property curHP As Integer
        Get
            Return m_curHP
        End Get
        Set(value As Integer)
            m_curHP = value
        End Set
    End Property

    Public Property baseHP As Integer
        Get
            Return m_baseHP
        End Get
        Set(value As Integer)
            m_baseHP = value
        End Set
    End Property

    Public Property baseatk As Integer
        Get
            Return m_baseAtk
        End Get
        Set(value As Integer)
            m_baseAtk = value
        End Set
    End Property

    Public Property Target As Boolean
        Get
            Return m_Target
        End Get
        Set(value As Boolean)
            m_Target = value
        End Set
    End Property

    Public Property id As Integer
        Get
            Return m_ID
        End Get
        Set(value As Integer)
            m_ID = value
        End Set
    End Property

    Public Sub recdmg(dmg As Integer)
        m_curHP -= dmg
    End Sub

    Public Event onDeath()

    Public Sub die()
        dead = True
        RaiseEvent onDeath()
    End Sub
End Class

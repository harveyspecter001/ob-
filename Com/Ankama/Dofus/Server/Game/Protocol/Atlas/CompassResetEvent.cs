using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Atlas
{
	// Token: 0x02000BFE RID: 3070
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CompassResetEvent : IMessage<CompassResetEvent>, IMessage, IEquatable<CompassResetEvent>, IDeepCloneable<CompassResetEvent>, IBufferMessage
	{
		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x0600939A RID: 37786 RVA: 0x00273888 File Offset: 0x00271A88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CompassResetEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x0600939B RID: 37787 RVA: 0x00273898 File Offset: 0x00271A98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x0600939C RID: 37788 RVA: 0x002738A8 File Offset: 0x00271AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x002738B8 File Offset: 0x00271AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CompassResetEvent()
		{
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x002738C8 File Offset: 0x00271AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CompassResetEvent(CompassResetEvent other)
		{
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x002738D8 File Offset: 0x00271AD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CompassResetEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x060093A0 RID: 37792 RVA: 0x002738E8 File Offset: 0x00271AE8
		// (set) Token: 0x060093A1 RID: 37793 RVA: 0x002738FC File Offset: 0x00271AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompassType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CompassType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x0027390C File Offset: 0x00271B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060093A3 RID: 37795 RVA: 0x0027391C File Offset: 0x00271B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CompassResetEvent other)
		{
			return true;
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x0027392C File Offset: 0x00271B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x0027393C File Offset: 0x00271B3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x0027394C File Offset: 0x00271B4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x0027395C File Offset: 0x00271B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x0027396C File Offset: 0x00271B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x0027397C File Offset: 0x00271B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CompassResetEvent other)
		{
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x0027398C File Offset: 0x00271B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x0027399C File Offset: 0x00271B9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x002739AC File Offset: 0x00271BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CompassResetEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					CompassResetEvent._parser = new MessageParser<CompassResetEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x00273A90 File Offset: 0x00271C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XpqFyUJEZkSGYIDSRHob()
		{
			return true;
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x00273A98 File Offset: 0x00271C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CompassResetEvent sVcsl4JEqOJLZglMyCXC()
		{
			return null;
		}

		// Token: 0x040036F5 RID: 14069
		private static readonly MessageParser<CompassResetEvent> _parser;

		// Token: 0x040036F6 RID: 14070
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036F7 RID: 14071
		public const int TypeFieldNumber = 1;

		// Token: 0x040036F8 RID: 14072
		private CompassType type_;

		// Token: 0x040036F9 RID: 14073
		private static CompassResetEvent vvKUZwJE82pJaYYfe4YD;
	}
}

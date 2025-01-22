using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x0200014C RID: 332
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DiceRollRequest : IMessage<DiceRollRequest>, IMessage, IEquatable<DiceRollRequest>, IDeepCloneable<DiceRollRequest>, IBufferMessage
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0019C8EC File Offset: 0x0019AAEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DiceRollRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0019C8FC File Offset: 0x0019AAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0019C90C File Offset: 0x0019AB0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0019C91C File Offset: 0x0019AB1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceRollRequest()
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0019C92C File Offset: 0x0019AB2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceRollRequest(DiceRollRequest other)
		{
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0019C93C File Offset: 0x0019AB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceRollRequest Clone()
		{
			return null;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0019C94C File Offset: 0x0019AB4C
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x0019C95C File Offset: 0x0019AB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Dice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x0019C96C File Offset: 0x0019AB6C
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x0019C97C File Offset: 0x0019AB7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Faces
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0019C98C File Offset: 0x0019AB8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0019C99C File Offset: 0x0019AB9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DiceRollRequest other)
		{
			return true;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0019C9AC File Offset: 0x0019ABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0019C9BC File Offset: 0x0019ABBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0019C9CC File Offset: 0x0019ABCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0019C9DC File Offset: 0x0019ABDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0019C9EC File Offset: 0x0019ABEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0019C9FC File Offset: 0x0019ABFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DiceRollRequest other)
		{
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0019CA0C File Offset: 0x0019AC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0019CA1C File Offset: 0x0019AC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0019CA2C File Offset: 0x0019AC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DiceRollRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_82;
					case 4:
						DiceRollRequest._parser = new MessageParser<DiceRollRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_82:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0019CAFC File Offset: 0x0019ACFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aAjaS7OUK4ldxrmVFJ0K()
		{
			return true;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0019CB04 File Offset: 0x0019AD04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DiceRollRequest vcRItQOUImfpOAJqC0aS()
		{
			return null;
		}

		// Token: 0x0400058B RID: 1419
		private static readonly MessageParser<DiceRollRequest> _parser;

		// Token: 0x0400058C RID: 1420
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400058D RID: 1421
		public const int DiceFieldNumber = 1;

		// Token: 0x0400058E RID: 1422
		private int dice_;

		// Token: 0x0400058F RID: 1423
		public const int FacesFieldNumber = 2;

		// Token: 0x04000590 RID: 1424
		private int faces_;

		// Token: 0x04000591 RID: 1425
		internal static DiceRollRequest OGj6QTOUjpOKo77Xfrn8;
	}
}

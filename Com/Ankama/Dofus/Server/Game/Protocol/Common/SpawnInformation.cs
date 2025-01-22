using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A12 RID: 2578
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpawnInformation : IMessage<SpawnInformation>, IMessage, IEquatable<SpawnInformation>, IDeepCloneable<SpawnInformation>, IBufferMessage
	{
		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06007AF6 RID: 31478 RVA: 0x0025BD38 File Offset: 0x00259F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpawnInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x0025BD48 File Offset: 0x00259F48
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

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06007AF8 RID: 31480 RVA: 0x0025BD58 File Offset: 0x00259F58
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

		// Token: 0x06007AF9 RID: 31481 RVA: 0x0025BD68 File Offset: 0x00259F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpawnInformation()
		{
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x0025BD78 File Offset: 0x00259F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpawnInformation(SpawnInformation other)
		{
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x0025BD88 File Offset: 0x00259F88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpawnInformation Clone()
		{
			return null;
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06007AFC RID: 31484 RVA: 0x0025BD98 File Offset: 0x00259F98
		// (set) Token: 0x06007AFD RID: 31485 RVA: 0x0025BDAC File Offset: 0x00259FAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06007AFE RID: 31486 RVA: 0x0025BDBC File Offset: 0x00259FBC
		// (set) Token: 0x06007AFF RID: 31487 RVA: 0x0025BDCC File Offset: 0x00259FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Alive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06007B00 RID: 31488 RVA: 0x0025BDDC File Offset: 0x00259FDC
		// (set) Token: 0x06007B01 RID: 31489 RVA: 0x0025BDEC File Offset: 0x00259FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActorPositionInformation Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x0025BDFC File Offset: 0x00259FFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x0025BE0C File Offset: 0x0025A00C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpawnInformation other)
		{
			return true;
		}

		// Token: 0x06007B04 RID: 31492 RVA: 0x0025BE1C File Offset: 0x0025A01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x0025BE2C File Offset: 0x0025A02C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x0025BE3C File Offset: 0x0025A03C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x0025BE4C File Offset: 0x0025A04C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x0025BE5C File Offset: 0x0025A05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x0025BE6C File Offset: 0x0025A06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpawnInformation other)
		{
		}

		// Token: 0x06007B0A RID: 31498 RVA: 0x0025BE7C File Offset: 0x0025A07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x0025BE8C File Offset: 0x0025A08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x0025BE9C File Offset: 0x0025A09C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpawnInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 1:
					return;
				case 2:
					SpawnInformation._parser = new MessageParser<SpawnInformation>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06007B0D RID: 31501 RVA: 0x0025BF68 File Offset: 0x0025A168
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NTVQnYJGBEEDq2NF5RIc()
		{
			return true;
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x0025BF70 File Offset: 0x0025A170
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpawnInformation kLpWCjJGewbdNw4Uy1hu()
		{
			return null;
		}

		// Token: 0x04002C0E RID: 11278
		private static readonly MessageParser<SpawnInformation> _parser;

		// Token: 0x04002C0F RID: 11279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C10 RID: 11280
		public const int TeamFieldNumber = 1;

		// Token: 0x04002C11 RID: 11281
		private Team team_;

		// Token: 0x04002C12 RID: 11282
		public const int AliveFieldNumber = 2;

		// Token: 0x04002C13 RID: 11283
		private bool alive_;

		// Token: 0x04002C14 RID: 11284
		public const int PositionFieldNumber = 3;

		// Token: 0x04002C15 RID: 11285
		private ActorPositionInformation position_;

		// Token: 0x04002C16 RID: 11286
		private static SpawnInformation JLqcJMJGAnY4dMBUs0eD;
	}
}

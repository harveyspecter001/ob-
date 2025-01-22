using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000DA3 RID: 3491
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NuggetsBeneficiary : IMessage<NuggetsBeneficiary>, IMessage, IEquatable<NuggetsBeneficiary>, IDeepCloneable<NuggetsBeneficiary>, IBufferMessage
	{
		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x0600A840 RID: 43072 RVA: 0x00294ED8 File Offset: 0x002930D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<NuggetsBeneficiary> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600A841 RID: 43073 RVA: 0x00294EE8 File Offset: 0x002930E8
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

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600A842 RID: 43074 RVA: 0x00294EF8 File Offset: 0x002930F8
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

		// Token: 0x0600A843 RID: 43075 RVA: 0x00294F08 File Offset: 0x00293108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsBeneficiary()
		{
		}

		// Token: 0x0600A844 RID: 43076 RVA: 0x00294F18 File Offset: 0x00293118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsBeneficiary(NuggetsBeneficiary other)
		{
		}

		// Token: 0x0600A845 RID: 43077 RVA: 0x00294F28 File Offset: 0x00293128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsBeneficiary Clone()
		{
			return null;
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x0600A846 RID: 43078 RVA: 0x00294F38 File Offset: 0x00293138
		// (set) Token: 0x0600A847 RID: 43079 RVA: 0x00294F48 File Offset: 0x00293148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CharacterId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x0600A848 RID: 43080 RVA: 0x00294F58 File Offset: 0x00293158
		// (set) Token: 0x0600A849 RID: 43081 RVA: 0x00294F68 File Offset: 0x00293168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NuggetsQuantity
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

		// Token: 0x0600A84A RID: 43082 RVA: 0x00294F78 File Offset: 0x00293178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A84B RID: 43083 RVA: 0x00294F88 File Offset: 0x00293188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NuggetsBeneficiary other)
		{
			return true;
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x00294F98 File Offset: 0x00293198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A84D RID: 43085 RVA: 0x00294FA8 File Offset: 0x002931A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A84E RID: 43086 RVA: 0x00294FB8 File Offset: 0x002931B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x00294FC8 File Offset: 0x002931C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x00294FD8 File Offset: 0x002931D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x00294FE8 File Offset: 0x002931E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NuggetsBeneficiary other)
		{
		}

		// Token: 0x0600A852 RID: 43090 RVA: 0x00294FF8 File Offset: 0x002931F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A853 RID: 43091 RVA: 0x00295008 File Offset: 0x00293208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A854 RID: 43092 RVA: 0x00295018 File Offset: 0x00293218
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NuggetsBeneficiary()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					NuggetsBeneficiary._parser = new MessageParser<NuggetsBeneficiary>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600A855 RID: 43093 RVA: 0x00295110 File Offset: 0x00293310
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rXZPLZJl6UZu5xFw0QI7()
		{
			return true;
		}

		// Token: 0x0600A856 RID: 43094 RVA: 0x00295118 File Offset: 0x00293318
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NuggetsBeneficiary iGZ7dSJlLDAwWDRV8Pxl()
		{
			return null;
		}

		// Token: 0x04003DE9 RID: 15849
		private static readonly MessageParser<NuggetsBeneficiary> _parser;

		// Token: 0x04003DEA RID: 15850
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DEB RID: 15851
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04003DEC RID: 15852
		private long characterId_;

		// Token: 0x04003DED RID: 15853
		public const int NuggetsQuantityFieldNumber = 2;

		// Token: 0x04003DEE RID: 15854
		private int nuggetsQuantity_;

		// Token: 0x04003DEF RID: 15855
		private static NuggetsBeneficiary oXlnGnJlyoGyNglVPjnn;
	}
}

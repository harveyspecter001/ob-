using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Living.Object
{
	// Token: 0x0200039E RID: 926
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LivingObjectDissociateRequest : IMessage<LivingObjectDissociateRequest>, IMessage, IEquatable<LivingObjectDissociateRequest>, IDeepCloneable<LivingObjectDissociateRequest>, IBufferMessage
	{
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x001CA7B4 File Offset: 0x001C89B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LivingObjectDissociateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x001CA7C4 File Offset: 0x001C89C4
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

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x001CA7D4 File Offset: 0x001C89D4
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

		// Token: 0x06002B60 RID: 11104 RVA: 0x001CA7E4 File Offset: 0x001C89E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectDissociateRequest()
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x001CA7F4 File Offset: 0x001C89F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectDissociateRequest(LivingObjectDissociateRequest other)
		{
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x001CA804 File Offset: 0x001C8A04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectDissociateRequest Clone()
		{
			return null;
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x001CA814 File Offset: 0x001C8A14
		// (set) Token: 0x06002B64 RID: 11108 RVA: 0x001CA824 File Offset: 0x001C8A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
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

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x001CA834 File Offset: 0x001C8A34
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x001CA844 File Offset: 0x001C8A44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Position
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

		// Token: 0x06002B67 RID: 11111 RVA: 0x001CA854 File Offset: 0x001C8A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x001CA864 File Offset: 0x001C8A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LivingObjectDissociateRequest other)
		{
			return true;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x001CA874 File Offset: 0x001C8A74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x001CA884 File Offset: 0x001C8A84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x001CA894 File Offset: 0x001C8A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x001CA8A4 File Offset: 0x001C8AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x001CA8B4 File Offset: 0x001C8AB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x001CA8C4 File Offset: 0x001C8AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LivingObjectDissociateRequest other)
		{
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x001CA8D4 File Offset: 0x001C8AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x001CA8E4 File Offset: 0x001C8AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x001CA8F4 File Offset: 0x001C8AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LivingObjectDissociateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_9C;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						return;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 1;
					}
				}
				IL_9C:
				LivingObjectDissociateRequest._parser = new MessageParser<LivingObjectDissociateRequest>(() => null);
				num = 4;
			}
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x001CA9C4 File Offset: 0x001C8BC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jcnEXLOVBZrmcabk1hgj()
		{
			return true;
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x001CA9CC File Offset: 0x001C8BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LivingObjectDissociateRequest v7xXiDOVeKrsJOnuGol6()
		{
			return null;
		}

		// Token: 0x04000F46 RID: 3910
		private static readonly MessageParser<LivingObjectDissociateRequest> _parser;

		// Token: 0x04000F47 RID: 3911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F48 RID: 3912
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04000F49 RID: 3913
		private int objectUid_;

		// Token: 0x04000F4A RID: 3914
		public const int PositionFieldNumber = 2;

		// Token: 0x04000F4B RID: 3915
		private int position_;

		// Token: 0x04000F4C RID: 3916
		internal static LivingObjectDissociateRequest PhbEK4OVAM5Rgd5KlvTF;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003E6 RID: 998
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectDropRequest : IMessage<ObjectDropRequest>, IMessage, IEquatable<ObjectDropRequest>, IDeepCloneable<ObjectDropRequest>, IBufferMessage
	{
		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x001D203C File Offset: 0x001D023C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectDropRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x001D204C File Offset: 0x001D024C
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

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x001D205C File Offset: 0x001D025C
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

		// Token: 0x06002EFD RID: 12029 RVA: 0x001D206C File Offset: 0x001D026C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDropRequest()
		{
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x001D207C File Offset: 0x001D027C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDropRequest(ObjectDropRequest other)
		{
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x001D208C File Offset: 0x001D028C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDropRequest Clone()
		{
			return null;
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x001D209C File Offset: 0x001D029C
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x001D20AC File Offset: 0x001D02AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectUidWithQuantity Object
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

		// Token: 0x06002F02 RID: 12034 RVA: 0x001D20BC File Offset: 0x001D02BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x001D20CC File Offset: 0x001D02CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectDropRequest other)
		{
			return true;
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x001D20DC File Offset: 0x001D02DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x001D20EC File Offset: 0x001D02EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x001D20FC File Offset: 0x001D02FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x001D210C File Offset: 0x001D030C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x001D211C File Offset: 0x001D031C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x001D212C File Offset: 0x001D032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectDropRequest other)
		{
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x001D213C File Offset: 0x001D033C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x001D214C File Offset: 0x001D034C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x001D215C File Offset: 0x001D035C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectDropRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					ObjectDropRequest._parser = new MessageParser<ObjectDropRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x001D2228 File Offset: 0x001D0428
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BpinyaO0c8Kl55B65WCS()
		{
			return true;
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x001D2230 File Offset: 0x001D0430
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectDropRequest hI9Fv0O0UMecN2s3ZpS7()
		{
			return null;
		}

		// Token: 0x0400108C RID: 4236
		private static readonly MessageParser<ObjectDropRequest> _parser;

		// Token: 0x0400108D RID: 4237
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400108E RID: 4238
		public const int ObjectFieldNumber = 1;

		// Token: 0x0400108F RID: 4239
		private ObjectUidWithQuantity object_;

		// Token: 0x04001090 RID: 4240
		internal static ObjectDropRequest dkarALO0l5O9ZNHjsea8;
	}
}

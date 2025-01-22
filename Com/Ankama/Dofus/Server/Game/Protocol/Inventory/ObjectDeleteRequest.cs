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
	// Token: 0x020003E8 RID: 1000
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectDeleteRequest : IMessage<ObjectDeleteRequest>, IMessage, IEquatable<ObjectDeleteRequest>, IDeepCloneable<ObjectDeleteRequest>, IBufferMessage
	{
		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x001D2238 File Offset: 0x001D0438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ObjectDeleteRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x001D2248 File Offset: 0x001D0448
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

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x001D2258 File Offset: 0x001D0458
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

		// Token: 0x06002F17 RID: 12055 RVA: 0x001D2268 File Offset: 0x001D0468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDeleteRequest()
		{
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x001D2278 File Offset: 0x001D0478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDeleteRequest(ObjectDeleteRequest other)
		{
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x001D2288 File Offset: 0x001D0488
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectDeleteRequest Clone()
		{
			return null;
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x001D2298 File Offset: 0x001D0498
		// (set) Token: 0x06002F1B RID: 12059 RVA: 0x001D22A8 File Offset: 0x001D04A8
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

		// Token: 0x06002F1C RID: 12060 RVA: 0x001D22B8 File Offset: 0x001D04B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x001D22C8 File Offset: 0x001D04C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectDeleteRequest other)
		{
			return true;
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x001D22D8 File Offset: 0x001D04D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x001D22E8 File Offset: 0x001D04E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x001D22F8 File Offset: 0x001D04F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x001D2308 File Offset: 0x001D0508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x001D2318 File Offset: 0x001D0518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x001D2328 File Offset: 0x001D0528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectDeleteRequest other)
		{
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x001D2338 File Offset: 0x001D0538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x001D2348 File Offset: 0x001D0548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x001D2358 File Offset: 0x001D0558
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectDeleteRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ObjectDeleteRequest._parser = new MessageParser<ObjectDeleteRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x001D243C File Offset: 0x001D063C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kyx3QDO0o1GH13XngmBy()
		{
			return true;
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x001D2444 File Offset: 0x001D0644
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectDeleteRequest RM0FxUO01PF6EeloQpYC()
		{
			return null;
		}

		// Token: 0x04001093 RID: 4243
		private static readonly MessageParser<ObjectDeleteRequest> _parser;

		// Token: 0x04001094 RID: 4244
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001095 RID: 4245
		public const int ObjectFieldNumber = 1;

		// Token: 0x04001096 RID: 4246
		private ObjectUidWithQuantity object_;

		// Token: 0x04001097 RID: 4247
		private static ObjectDeleteRequest UmpbT8O0vXjd57kHlfxn;
	}
}

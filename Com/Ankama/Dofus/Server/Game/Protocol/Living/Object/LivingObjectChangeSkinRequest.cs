using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Living.Object
{
	// Token: 0x020003A0 RID: 928
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LivingObjectChangeSkinRequest : IMessage<LivingObjectChangeSkinRequest>, IMessage, IEquatable<LivingObjectChangeSkinRequest>, IDeepCloneable<LivingObjectChangeSkinRequest>, IBufferMessage
	{
		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x001CA9D4 File Offset: 0x001C8BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LivingObjectChangeSkinRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002B7A RID: 11130 RVA: 0x001CA9E4 File Offset: 0x001C8BE4
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

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x001CA9F4 File Offset: 0x001C8BF4
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

		// Token: 0x06002B7C RID: 11132 RVA: 0x001CAA04 File Offset: 0x001C8C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectChangeSkinRequest()
		{
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x001CAA14 File Offset: 0x001C8C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectChangeSkinRequest(LivingObjectChangeSkinRequest other)
		{
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x001CAA24 File Offset: 0x001C8C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LivingObjectChangeSkinRequest Clone()
		{
			return null;
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x001CAA34 File Offset: 0x001C8C34
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x001CAA44 File Offset: 0x001C8C44
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

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x001CAA54 File Offset: 0x001C8C54
		// (set) Token: 0x06002B82 RID: 11138 RVA: 0x001CAA64 File Offset: 0x001C8C64
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

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x001CAA74 File Offset: 0x001C8C74
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x001CAA84 File Offset: 0x001C8C84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SkinId
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

		// Token: 0x06002B85 RID: 11141 RVA: 0x001CAA94 File Offset: 0x001C8C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x001CAAA4 File Offset: 0x001C8CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LivingObjectChangeSkinRequest other)
		{
			return true;
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x001CAAB4 File Offset: 0x001C8CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x001CAAC4 File Offset: 0x001C8CC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x001CAAD4 File Offset: 0x001C8CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x001CAAE4 File Offset: 0x001C8CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x001CAAF4 File Offset: 0x001C8CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x001CAB04 File Offset: 0x001C8D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LivingObjectChangeSkinRequest other)
		{
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x001CAB14 File Offset: 0x001C8D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x001CAB24 File Offset: 0x001C8D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x001CAB34 File Offset: 0x001C8D34
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LivingObjectChangeSkinRequest()
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
					default:
						return;
					case 1:
						LivingObjectChangeSkinRequest._parser = new MessageParser<LivingObjectChangeSkinRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						break;
					case 3:
						goto IL_AC;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
				IL_AC:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x001CAC04 File Offset: 0x001C8E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DiY2cZOVRxTsI5FaGl1E()
		{
			return true;
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x001CAC0C File Offset: 0x001C8E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LivingObjectChangeSkinRequest XYSqmkOVOLoTw6q716gW()
		{
			return null;
		}

		// Token: 0x04000F4F RID: 3919
		private static readonly MessageParser<LivingObjectChangeSkinRequest> _parser;

		// Token: 0x04000F50 RID: 3920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F51 RID: 3921
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04000F52 RID: 3922
		private int objectUid_;

		// Token: 0x04000F53 RID: 3923
		public const int PositionFieldNumber = 2;

		// Token: 0x04000F54 RID: 3924
		private int position_;

		// Token: 0x04000F55 RID: 3925
		public const int SkinIdFieldNumber = 3;

		// Token: 0x04000F56 RID: 3926
		private int skinId_;

		// Token: 0x04000F57 RID: 3927
		internal static LivingObjectChangeSkinRequest TFRDDNOV3SratCJD8ndG;
	}
}

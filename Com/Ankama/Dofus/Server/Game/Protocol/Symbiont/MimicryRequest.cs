using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont
{
	// Token: 0x02000102 RID: 258
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MimicryRequest : IMessage<MimicryRequest>, IMessage, IEquatable<MimicryRequest>, IDeepCloneable<MimicryRequest>, IBufferMessage
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00196220 File Offset: 0x00194420
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MimicryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00196230 File Offset: 0x00194430
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

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00196240 File Offset: 0x00194440
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

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00196250 File Offset: 0x00194450
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryRequest()
		{
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00196260 File Offset: 0x00194460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryRequest(MimicryRequest other)
		{
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00196270 File Offset: 0x00194470
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MimicryRequest Clone()
		{
			return null;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00196280 File Offset: 0x00194480
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00196290 File Offset: 0x00194490
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SymbiontUid
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x001962A0 File Offset: 0x001944A0
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x001962B0 File Offset: 0x001944B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int HostUid
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

		// Token: 0x06000BBE RID: 3006 RVA: 0x001962C0 File Offset: 0x001944C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x001962D0 File Offset: 0x001944D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MimicryRequest other)
		{
			return true;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x001962E0 File Offset: 0x001944E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x001962F0 File Offset: 0x001944F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00196300 File Offset: 0x00194500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00196310 File Offset: 0x00194510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00196320 File Offset: 0x00194520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00196330 File Offset: 0x00194530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MimicryRequest other)
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00196340 File Offset: 0x00194540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00196350 File Offset: 0x00194550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00196360 File Offset: 0x00194560
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MimicryRequest()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				MimicryRequest._parser = new MessageParser<MimicryRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0019642C File Offset: 0x0019462C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool krCAOwOlTe6p4gVh5Kdu()
		{
			return true;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00196434 File Offset: 0x00194634
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MimicryRequest pRbd77Olpcx86N5qCvXw()
		{
			return null;
		}

		// Token: 0x04000447 RID: 1095
		private static readonly MessageParser<MimicryRequest> _parser;

		// Token: 0x04000448 RID: 1096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000449 RID: 1097
		public const int SymbiontUidFieldNumber = 1;

		// Token: 0x0400044A RID: 1098
		private int symbiontUid_;

		// Token: 0x0400044B RID: 1099
		public const int HostUidFieldNumber = 2;

		// Token: 0x0400044C RID: 1100
		private int hostUid_;

		// Token: 0x0400044D RID: 1101
		private static MimicryRequest XtqF5qOl7tO0T3wJLn5I;
	}
}

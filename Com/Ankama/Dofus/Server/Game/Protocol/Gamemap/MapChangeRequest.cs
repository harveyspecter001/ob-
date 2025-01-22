using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x0200057E RID: 1406
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapChangeRequest : IMessage<MapChangeRequest>, IMessage, IEquatable<MapChangeRequest>, IDeepCloneable<MapChangeRequest>, IBufferMessage
	{
		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060043B1 RID: 17329 RVA: 0x001F55C4 File Offset: 0x001F37C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapChangeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060043B2 RID: 17330 RVA: 0x001F55D4 File Offset: 0x001F37D4
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

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x001F55E4 File Offset: 0x001F37E4
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

		// Token: 0x060043B4 RID: 17332 RVA: 0x001F55F4 File Offset: 0x001F37F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeRequest()
		{
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x001F5604 File Offset: 0x001F3804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeRequest(MapChangeRequest other)
		{
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x001F5614 File Offset: 0x001F3814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeRequest Clone()
		{
			return null;
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x001F5624 File Offset: 0x001F3824
		// (set) Token: 0x060043B8 RID: 17336 RVA: 0x001F5634 File Offset: 0x001F3834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MapId
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

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x001F5644 File Offset: 0x001F3844
		// (set) Token: 0x060043BA RID: 17338 RVA: 0x001F5654 File Offset: 0x001F3854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AutoPilot
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

		// Token: 0x060043BB RID: 17339 RVA: 0x001F5664 File Offset: 0x001F3864
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x001F5674 File Offset: 0x001F3874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapChangeRequest other)
		{
			return true;
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x001F5684 File Offset: 0x001F3884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x001F5694 File Offset: 0x001F3894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x001F56A4 File Offset: 0x001F38A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x001F56B4 File Offset: 0x001F38B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x001F56C4 File Offset: 0x001F38C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x001F56D4 File Offset: 0x001F38D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapChangeRequest other)
		{
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x001F56E4 File Offset: 0x001F38E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x001F56F4 File Offset: 0x001F38F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x001F5704 File Offset: 0x001F3904
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapChangeRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					MapChangeRequest._parser = new MessageParser<MapChangeRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x001F57FC File Offset: 0x001F39FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OFO0nWOYAOkRIfnB0B5T()
		{
			return true;
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x001F5804 File Offset: 0x001F3A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapChangeRequest kuKAuJOYBXUN7CI0CAqB()
		{
			return null;
		}

		// Token: 0x0400174F RID: 5967
		private static readonly MessageParser<MapChangeRequest> _parser;

		// Token: 0x04001750 RID: 5968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001751 RID: 5969
		public const int MapIdFieldNumber = 1;

		// Token: 0x04001752 RID: 5970
		private int mapId_;

		// Token: 0x04001753 RID: 5971
		public const int AutoPilotFieldNumber = 2;

		// Token: 0x04001754 RID: 5972
		private bool autoPilot_;

		// Token: 0x04001755 RID: 5973
		internal static MapChangeRequest TOXa6rOYmhFnJwvt3Bqf;
	}
}

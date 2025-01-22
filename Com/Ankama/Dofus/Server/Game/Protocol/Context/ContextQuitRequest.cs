using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x02000807 RID: 2055
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContextQuitRequest : IMessage<ContextQuitRequest>, IMessage, IEquatable<ContextQuitRequest>, IDeepCloneable<ContextQuitRequest>, IBufferMessage
	{
		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x002261E8 File Offset: 0x002243E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContextQuitRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x002261F8 File Offset: 0x002243F8
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

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600640C RID: 25612 RVA: 0x00226208 File Offset: 0x00224408
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

		// Token: 0x0600640D RID: 25613 RVA: 0x00226218 File Offset: 0x00224418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextQuitRequest()
		{
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x00226228 File Offset: 0x00224428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextQuitRequest(ContextQuitRequest other)
		{
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x00226238 File Offset: 0x00224438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextQuitRequest Clone()
		{
			return null;
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x00226248 File Offset: 0x00224448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x00226258 File Offset: 0x00224458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ContextQuitRequest other)
		{
			return true;
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x00226268 File Offset: 0x00224468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x00226278 File Offset: 0x00224478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x00226288 File Offset: 0x00224488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x00226298 File Offset: 0x00224498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x002262A8 File Offset: 0x002244A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x002262B8 File Offset: 0x002244B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ContextQuitRequest other)
		{
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x002262C8 File Offset: 0x002244C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x002262D8 File Offset: 0x002244D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x002262E8 File Offset: 0x002244E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextQuitRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ContextQuitRequest._parser = new MessageParser<ContextQuitRequest>(() => null);
					num2 = 4;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x002263B4 File Offset: 0x002245B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BW0qsJOz58yM7OU5OZbw()
		{
			return true;
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x002263BC File Offset: 0x002245BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextQuitRequest pg2EOWOzyKMVjYPZM77o()
		{
			return null;
		}

		// Token: 0x0400232F RID: 9007
		private static readonly MessageParser<ContextQuitRequest> _parser;

		// Token: 0x04002330 RID: 9008
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002331 RID: 9009
		internal static ContextQuitRequest UCT8i0OzanKjHLZZPNKu;
	}
}
